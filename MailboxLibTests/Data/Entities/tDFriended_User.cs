using System;
using MailboxLib.Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailboxLibUnitTests.Data.Entities{
    [TestClass]
    public class tDFriended_User{
        [TestMethod]
        public void DFriended_User_WhenAskedForKey_ReturnsFriended_User_ID(){
            //Arrange: A friended user with a unique key is constructed.
            DFriended_User friended_user = new DFriended_User { Friended_User_ID = -1 };

            //Act: the key is retrieved.
            int key = friended_user.key;

            //Assert: the key is the same as the friended user's ID.
            Assert.AreEqual(key, friended_user.Friended_User_ID);
        }

        [TestMethod]
        public void DFriended_UserWithHtmlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: A friended user with malicious sql members is constructed.
            string malicious = "<div></div>";
            DFriended_User friended_user = new DFriended_User{
                username = malicious,
                Author_Name = malicious
            };

            //Act: The friended user is scrubbed.
            friended_user.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, friended_user.username);
            Assert.AreNotEqual(malicious, friended_user.Author_Name);
        }

        [TestMethod]
        public void DFriended_UserWithSqlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: A friended user with malicious html and sql members is constructed.
            string malicious = "1');DELETE TABLE dbo.example;--";
            DFriended_User friended_user = new DFriended_User{
                username = malicious,
                Author_Name = malicious
            };

            //Act: The friended user is scrubbed.
            friended_user.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, friended_user.username);
            Assert.AreNotEqual(malicious, friended_user.Author_Name);
        }
    }
}
