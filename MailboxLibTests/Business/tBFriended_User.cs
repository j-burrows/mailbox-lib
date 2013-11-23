using System;
using MailboxLib.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailboxLibUnitTests.Business{
    [TestClass]
    public class tBFriended_User{
        [TestMethod]
        public void BFriended_UserWithValidMembers_WhenCreateValidated_ReturnsTrue(){
            //Arrange: A friended user with all valid members is created.
            BFriended_User friended_user = new BFriended_User
            {
                username = "owner",
                Author_Name = "blocked"
            };

            //Act: the friended user is checked if it is create valid.
            bool valid = friended_user.CreateValid();

            //Assert: the friended user is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BFriended_UserWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: A friended user with all invalid members is created.
            BFriended_User friended_user = new BFriended_User
            {
                username = null,
                Author_Name = "123456789012345678789012345678901234567890"
            };

            //Act: the friended user is checked if it is create valid.
            bool valid = friended_user.CreateValid();

            //Assert: the friended user is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BFriended_UserWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: A friended user with all valid members is created.
            BFriended_User friended_user = new BFriended_User
            {
                username = "owner",
                Author_Name = "blocked"
            };

            //Act: the friended user is checked if it is update valid.
            bool valid = friended_user.UpdateValid();

            //Assert: the friended user is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BFriended_UserWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: A friended user with all invalid members is created.
            BFriended_User friended_user = new BFriended_User
            {
                username = null,
                Author_Name = "123456789012345678789012345678901234567890"
            };

            //Act: the friended user is checked if it is update valid.
            bool valid = friended_user.UpdateValid();

            //Assert: the friended user is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: A friended user is created
            BFriended_User friended_user = new BFriended_User();

            //Act: the friended user is checked if it is update valid.
            bool valid = friended_user.DeleteValid();

            //Assert: the friended user is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BBlocked_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: A friended user is created
            BFriended_User friended_user = new BFriended_User();

            //Act: the friended user is checked to be equivilant to itself.
            bool equals = friended_user.Equivilant(friended_user);

            //Assert: the friended user is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
