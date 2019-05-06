using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject_Udemy
{
    [TestFixture]
    class BankAccountTest
    {
        private BankAccount ba;
        [Test]
        public void DepositTest()
        {
            var log = new Mock<ILog>();
            ba = new BankAccount(100, log.Object);
            ba.Deposit(100);
            Assert.That(ba.balance, Is.EqualTo(200));
        }
    }
}
