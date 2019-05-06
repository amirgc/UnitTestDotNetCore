using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject_Udemy
{
    class NullLog : ILog
    {
        public void Write(string message)
        {
           
        }
    }
    [TestFixture]
    public class DataDrivenTest
    {
        private BankAccount ba;
        [SetUp]
        public void Setup()
        {
            NullLog nullLog = new NullLog();
            ba = new BankAccount(100, nullLog);
        }

        [Test]
        [TestCase(50, true, 50)]
        [TestCase(100, true, 0)]
        [TestCase(1005, false, 100)]
        public void TestMultipleWithdrawalScenarios(int amountToWithdraw, bool shouldsucceed, int expectedBalance)
        {
            var result = ba.Withdraw(amountToWithdraw);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(shouldsucceed));
                Assert.That(expectedBalance, Is.EqualTo(ba.balance));
            });

        }

        [Test]
        public void BankAccountShouldThrowOnNonPositiveAmount()
        {
            var ex = Assert.Throws<ArgumentException>(() => ba.Deposit(-1));
            StringAssert.StartsWith("Deposit amount must be positive", ex.Message);
        }


    }



}
