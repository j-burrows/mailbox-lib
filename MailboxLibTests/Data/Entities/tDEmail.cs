using System;
using MailboxLib.Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailboxLibUnitTests.Data.Entities{
    [TestClass]
    public class tDEmail{
        [TestMethod]
        public void DEmail_WhenAskedForKey_ReturnsEmail_ID(){
            //Arrange: An email with a unique key is constructed.
            DEmail email = new DEmail { Email_ID = -1 };

            //Act: the key is retrieved.
            int key = email.key;

            //Assert: the key is the same as the friended user's ID.
            Assert.AreEqual(key, email.Email_ID);
        }

        [TestMethod]
        public void DEmailWithHtmlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An email with malicious sql members is constructed.
            string malicious = "<div></div>";
            DEmail email = new DEmail{
                Title = malicious,
                Body = malicious,
                Sender = malicious,
                Recipient = malicious
            };

            //Act: The friended user is scrubbed.
            email.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, email.Title);
            Assert.AreNotEqual(malicious, email.Body);
            Assert.AreNotEqual(malicious, email.Sender);
            Assert.AreNotEqual(malicious, email.Recipient);
        }

        [TestMethod]
        public void DEmailWithSqlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An email with malicious html and sql members is constructed.
            string malicious = "1');DELETE TABLE dbo.example;--";
            DEmail email = new DEmail{
                Title = malicious,
                Body = malicious,
                Sender = malicious,
                Recipient = malicious
            };

            //Act: The friended user is scrubbed.
            email.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, email.Title);
            Assert.AreNotEqual(malicious, email.Body);
            Assert.AreNotEqual(malicious, email.Sender);
            Assert.AreNotEqual(malicious, email.Recipient);
        }
    }
}
