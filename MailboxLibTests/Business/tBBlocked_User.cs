using System;
using MailboxLib.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailboxLibUnitTests.Business{
    [TestClass]
    public class tBBlocked_User{
        [TestMethod]
        public void BBlocked_UserWithValidMembers_WhenCreateValidated_ReturnsTrue() { 
            //Arrange: A blocked user with all valid members is created.
            BBlocked_User blocked_user = new BBlocked_User { 
                username="owner", 
                Author_Name="blocked"
            };
            
            //Act: the blocked user is checked if it is create valid.
            bool valid = blocked_user.CreateValid();

            //Assert: the blocked user is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BBlocked_UserWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: A blocked user with all invalid members is created.
            BBlocked_User blocked_user = new BBlocked_User{
                username = null,
                Author_Name = "123456789012345678789012345678901234567890"
            };

            //Act: the blocked user is checked if it is create valid.
            bool valid = blocked_user.CreateValid();

            //Assert: the blocked user is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_UserWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: A blocked user with all valid members is created.
            BBlocked_User blocked_user = new BBlocked_User{
                username = "owner",
                Author_Name = "blocked"
            };

            //Act: the blocked user is checked if it is update valid.
            bool valid = blocked_user.UpdateValid();

            //Assert: the blocked user is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BBlocked_UserWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: A blocked user with all invalid members is created.
            BBlocked_User blocked_user = new BBlocked_User{
                username = null,
                Author_Name = "123456789012345678789012345678901234567890"
            };

            //Act: the blocked user is checked if it is update valid.
            bool valid = blocked_user.UpdateValid();

            //Assert: the blocked user is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: A blocked user is created
            BBlocked_User blocked_user = new BBlocked_User();

            //Act: the blocked user is checked if it is update valid.
            bool valid = blocked_user.DeleteValid();

            //Assert: the blocked user is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BBlocked_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: A blocked user is created
            BBlocked_User blocked_user = new BBlocked_User();

            //Act: the blocked user is checked to be equivilant to itself.
            bool equals = blocked_user.Equivilant(blocked_user);

            //Assert: the blocked user is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
