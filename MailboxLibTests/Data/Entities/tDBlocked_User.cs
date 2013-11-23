using System;
using MailboxLib.Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailboxLibUnitTests.Data.Entities{
    [TestClass]
    public class tDBlocked_User{
        [TestMethod]
        public void DBlocked_User_WhenAskedForKey_ReturnsBlocked_User_ID() {
            //Arrange: A blocked user with a unique key is constructed.
            DBlocked_User blocked_user = new DBlocked_User { Blocked_User_ID = -1};

            //Act: the key is retrieved.
            int key = blocked_user.key;

            //Assert: the key is the same as the blocked user's ID.
            Assert.AreEqual(key, blocked_user.Blocked_User_ID);
        }

        [TestMethod]
        public void DBlocked_UserWithHtmlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: A blocked user with malicious sql members is constructed.
            string malicious = "<div></div>";
            DBlocked_User blocked_user = new DBlocked_User{
                username = malicious,
                Author_Name = malicious
            };

            //Act: The blocked user is scrubbed.
            blocked_user.Scrub();

            //Assert: The blocked user has no html in its members.
            Assert.AreNotEqual(malicious, blocked_user.username);
            Assert.AreNotEqual(malicious, blocked_user.Author_Name);
        }

        [TestMethod]
        public void DBlocked_UserWithSqlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: A blocked user with malicious html and sql members are constructed.
            string malicious = "1');DELETE TABLE dbo.example;--";
            DBlocked_User blocked_user = new DBlocked_User{
                username = malicious,
                Author_Name = malicious
            };

            //Act: The blocked user is scrubbed.
            blocked_user.Scrub();

            //Assert: The blocked user has no html in its members.
            Assert.AreNotEqual(malicious, blocked_user.username);
            Assert.AreNotEqual(malicious, blocked_user.Author_Name);
        }
    }
}
