/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSBlocked_UserRepository.cs
 |  Purpose:    Collection of blocked users which can communicate with a sql server database
 |  Date:       October 14th 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Data;
using System.Data.SqlClient;
using MailboxLib.Data.Entities;
using Repository.Concrete;
using Repository.Helpers;
using Repository.Data;
namespace MailboxLib.Data.Repositories{
    public class SqlSBlocked_UserRepository : SqlSRepository<DBlocked_User>{
        public SqlSBlocked_UserRepository(string username) {
            //Repository is filled with every blocked user associated with given user.
            string query = string.Format(
                @"EXEC Mail.Blocked_User_GetByUser @username = '{0}';",
                username
            );
            FillRepository(query);
        }

        protected override void CreateEval(DBlocked_User creating){
            SqlCommand command = new SqlCommand("Mail.Blocked_User_Create");
            command.AddParam("Author_Name", creating.Author_Name);
            command.AddParam("username", creating.username);

            //The entry is created in the database and creating assigned resulting key.
            creating.key = ExecStoredProcedure(command);

            base.CreateEval(creating);      //Entry is created in main memory collection.
        }

        protected override void UpdateEval(DBlocked_User updating){
            SqlCommand command = new SqlCommand("Mail.Blocked_User_Update");
            command.AddParam("Blocked_User_ID", updating.Blocked_User_ID);
            command.AddParam("username", updating.username);

            ExecNonReader(command);             //The entry is updated in the database.

            base.UpdateEval(updating);      //Entry is created in main memory collection.
        }

        protected override void DeleteEval(DBlocked_User deleting){
            SqlCommand command = new SqlCommand("Mail.Blocked_User_Delete");
            command.AddParam("Blocked_User_ID", deleting.Blocked_User_ID);

            ExecNonReader(command);             //The entry is removed from the database.

            base.DeleteEval(deleting);      //Entry is removed from main memory collection.
        }
    }
}
