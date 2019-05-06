using JetBrains.dotMemoryUnit;
using JetBrains.dotMemoryUnit.Kernel;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class Tests
    {


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Warnings()
        {
            Warn.If(2 + 2 != 5);
            Warn.If(2 + 2, Is.Not.EqualTo(5));
        }
        [Test]
        public void DotMemoryCheck()
        {
            var checkPoint1 = dotMemory.Check();
            var checkpoint2 = dotMemory.Check(memory =>
                 {
                     Assert.That(memory.GetTrafficFrom(checkPoint1)
                         .Where(typeMemoryInfo => typeMemoryInfo.Interface.Is<IEnumerable<int>>())
                         .AllocatedMemory.SizeInBytes, Is.LessThan(-1));
                 });
        }


    }
}