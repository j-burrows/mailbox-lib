using System;
using MailboxLib.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailboxLibUnitTests.Business{
    [TestClass]
    public class tBEmail{
        [TestMethod]
        public void BEmailWithValidMembers_WhenCreateValidated_ReturnsTrue(){
            //Arrange: An email with all valid members is created.
            BEmail email = new BEmail{
                Title = "Title",
                Body = "Body",
                Recipient = "Recipient",
                Sender = "Sender"
            };

            //Act: the blocked user is checked if it is create valid.
            bool valid = email.CreateValid();

            //Assert: the blocked user is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BEmailWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: An email with all invalid members is created.
            BEmail email = new BEmail{
                Title = "1234567890123456789012345678901234567890",
                Body = null,
                Recipient = null,
                Sender = null
            };

            //Act: the blocked user is checked if it is create valid.
            bool valid = email.CreateValid();

            //Assert: the blocked user is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BEmailWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: An email with all valid members is created.
            BEmail email = new BEmail{
                Title = "Title",
                Body = "Body",
                Recipient = "Recipient",
                Sender = "Sender"
            };

            //Act: the blocked user is checked if it is update valid.
            bool valid = email.UpdateValid();

            //Assert: the blocked user is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BEmailWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: An email with all invalid members is created.
            BEmail email = new BEmail{
                Title = "1234567890123456789012345678901234567890",
                Body = null,
                Recipient = null,
                Sender = null
            };

            //Act: the blocked user is checked if it is update valid.
            bool valid = email.UpdateValid();

            //Assert: the blocked user is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: An email is created
            BEmail email = new BEmail();

            //Act: the blocked user is checked if it is update valid.
            bool valid = email.DeleteValid();

            //Assert: the blocked user is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BBlocked_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: An email is created
            BEmail email = new BEmail();

            //Act: the blocked user is checked to be equivilant to itself.
            bool equals = email.Equivilant(email);

            //Assert: the blocked user is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
