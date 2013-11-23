using System;
using MailboxLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailboxLibUnitTests.Presentation{
    [TestClass]
    public class tPBlocked_User{
        [TestMethod]
        public void PBlocked_User_WithNullMembers_WhenFormatted_HasEmptyMembers(){
            //Arrange: a blocked user with null members is constructed.
            PBlocked_User blocked_user = new PBlocked_User { 
                Author_Name = null, 
                username = null 
            };

            //Act: The blocked user is formatted.
            blocked_user.Format();

            //Assert: The blocked user's null members are replaced with empty members.
            Assert.AreEqual(string.Empty, blocked_user.Author_Name);
            Assert.AreEqual(string.Empty, blocked_user.username);
        }
    }
}
