using System;
using MailboxLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailboxLibUnitTests.Presentation{
    [TestClass]
    public class tPEmail{
        [TestMethod]
        public void PEmailWithNullMembers_WhenFormatted_HasEmptyMembers() { 
            //Arrange: an email with null members is constructed.
            PEmail email = new PEmail { 
                Title = null, 
                Body = null, 
                Recipient = null, 
                Sender = null
            };

            //Act: The email is formatted.
            email.Format();

            //Assert: The email's null members are replaced with empty members.
            Assert.AreEqual(string.Empty, email.Title);
            Assert.AreEqual(string.Empty, email.Body);
            Assert.AreEqual(string.Empty, email.Recipient);
            Assert.AreEqual(string.Empty, email.Sender);
        }
    }
}
