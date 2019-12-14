using CreditCardApplication.Handler;
using CreditCardApplication.Models;
using CreditCardApplication.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject_Udemy
{
    [TestFixture]
    class CreditCardTest
    {

        [Test]
        public void ShouldReturnListOfUser()
        {
            var mockService = new Mock<ICreditCardService<BankUser>>();

            mockService.Setup(x => x.GetListOfUsers()).Returns(ReturnListOfUser());

            var hand = new BaseHandler<BankUser>(mockService.Object);

            Assert.AreEqual(hand.GetListOfUsers().Count, 2);
            hand.GetListOfUsers();
        }

        public List<BankUser> ReturnListOfUser()
        {
            var list = new List<BankUser>
            {
                new BankUser{ Id=1,UserName="Jack" },
                new BankUser{ Id=1,UserName="Jill" }
            };
            return list;
        }
    }
}
