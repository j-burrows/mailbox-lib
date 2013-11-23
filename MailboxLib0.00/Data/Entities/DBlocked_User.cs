/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DBlocked_User.cs
 |  Purpose:    Defines the data access logic of a blocked user.
 |  Date:       October 14th 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Data;
using Repository.Helpers;
namespace MailboxLib.Data.Entities{
    public class DBlocked_User: MailboxLib.Business.BBlocked_User, IDataUnit{
        //Primary key used for indexing in the database.
        public int key {
            get { return Blocked_User_ID; }
            set { Blocked_User_ID = value; }
        }

        //Parameterless constructor used for model binding.
        public DBlocked_User() { }
        public DBlocked_User(System.Data.DataRow row){
            //Row from the database is parsed into a blocked user.
            Blocked_User_ID = row["Blocked_User_ID"].ToInt();
            Author_Name = row["Author_Name"].ToStr();
            username = row["username"].ToStr();
        }

        public override bool Equivilant(global::Repository.Business.IBusinessUnit comparing){
            DBlocked_User converted;
            //Equivilant iif of matching type and keys.
            if ((converted = comparing as DBlocked_User) != null){
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
