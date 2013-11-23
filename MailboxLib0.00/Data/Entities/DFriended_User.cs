/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DFriended_User.cs
 |  Purpose:    Defines the data access logic of a friended user.
 |  Date:       October 14th 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using Repository.Data;
using Repository.Helpers;
namespace MailboxLib.Data.Entities{
    public class DFriended_User : MailboxLib.Business.BFriended_User, IDataUnit{
        //Primary key used for indexing in the database.
        public int key {
            get { return Friended_User_ID; }
            set { Friended_User_ID = value; }
        }

        //Parameterless constructor used for model binding.
        public DFriended_User() { }
        public DFriended_User(DataRow row){
            //Row from the database is parsed into a blocked user.
            Friended_User_ID = row["Friended_User_ID"].ToInt();
            Author_Name = row["Author_Name"].ToStr();
            username = row["username"].ToStr();
        }

        public override bool Equivilant(global::Repository.Business.IBusinessUnit comparing){
            DFriended_User converted;
            //Equivilant iif of matching type and keys.
            if ((converted = comparing as DFriended_User) != null){
                if (converted.key == key){
                    return true;
                }
            }
            return false;
        }

        public void Scrub() {
            //All string members are scrubbed.
            Author_Name = Author_Name.Scrub();
            username = username.Scrub();
        }
    }
}
