/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSFriended_UserRepository.cs
 |  Purpose:    Collection of friended users which can communicate with sql server database
 |  Author:     Jonathan Burrows
 |  Date:       October 14th 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using System.Data.SqlClient;
using MailboxLib.Data.Entities;
using Repository.Concrete;
using Repository.Helpers;
using Repository.Data;
namespace MailboxLib.Data.Repositories{
    public class SqlSFriended_UserRepository : SqlSRepository<DFriended_User>{
        public SqlSFriended_UserRepository(string username) {
            //Collection is filled with all friended user beloging to given users.
            string query = string.Format(
                @"EXEC Mail.Friended_User_GetByUser @username = '{0}';",
                username
            );
            FillRepository(query);
        }

        protected override void CreateEval(DFriended_User creating){
            SqlCommand command = new SqlCommand("Mail.Friended_User_Create");
            command.AddParam("Author_Name", creating.Author_Name);
            command.AddParam("username", creating.username);

            //The entry is created in the database and assigned the returned key.
            creating.key = ExecStoredProcedure(command);             

            base.CreateEval(creating);      //Entry is created in main memory collection.
        }

        protected override void UpdateEval(DFriended_User updating){
            SqlCommand command = new SqlCommand("Mail.Friended_User_Update");
            command.AddParam("Friended_User_ID", updating.Friended_User_ID);
            command.AddParam("Author_Name", updating.Author_Name);

            ExecNonReader(command);         //The entry is updated in the database.

            base.UpdateEval(updating);      //Entry is created in main memory collection.
        }

        protected override void DeleteEval(DFriended_User deleting){
            SqlCommand command = new SqlCommand("Mail.Friended_User_Delete");
            command.AddParam("Friended_User_ID", deleting.Friended_User_ID);

            ExecNonReader(command);         //The entry is removed from the database.

            base.DeleteEval(deleting);      //Entry is removed from main memory collection.
        }
    }
}
