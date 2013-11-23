using System;
using MailboxLib.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailboxLibUnitTests.Base{
    [TestClass]
    public class tEmail{
        [TestMethod]
        public void Email_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: An email pointer is declared.
            Email email;

            //Act: The pointer is constructed without parameters.
            email = new Email();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, email);
        }
    }
}
