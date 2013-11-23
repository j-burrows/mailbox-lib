using System;
using MailboxLib.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailboxLibUnitTests.Base{
    [TestClass]
    public class tBlocked_User{
        [TestMethod]
        public void BlockedUser_WhenParameterlesslyConstructed_IsInstantiated() { 
            //Arrange: A blocked user pointer is declared.
            Blocked_User blocked_user;

            //Act: The pointer is constructed without parameters.
            blocked_user = new Blocked_User();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, blocked_user);
        }
    }
}
