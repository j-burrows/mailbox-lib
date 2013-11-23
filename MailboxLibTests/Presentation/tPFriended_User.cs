using System;
using MailboxLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailboxLibUnitTests.Presentation{
    [TestClass]
    public class tPFriended_User{
        [TestMethod]
        public void PFriended_User_WithNullMembers_WhenFormatted_HasEmptyMembers(){
            //Arrange: a friendly user with null members is constructed.
            PFriended_User friended_user = new PFriended_User {
                Author_Name=null, 
                username=null
            };

            //Act: The friendly user is formatted.
            friended_user.Format();

            //Assert: The friended user's null members are replaced with empty members.
            Assert.AreEqual(string.Empty, friended_user.Author_Name);
            Assert.AreEqual(string.Empty, friended_user.username);
        }
    }
}
