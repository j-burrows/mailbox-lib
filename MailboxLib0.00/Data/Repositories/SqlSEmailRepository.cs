/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   SqlSEmailRepository.cs
 |  Purpose:    Collection of emails which can communicate with a sql server database.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MailboxLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;
namespace MailboxLib.Data.Repositories{
    public class SqlSEmailRepository : SqlSRepository<DEmail>{
        public SqlSEmailRepository(string username) : base() {
            //Collection is filled with all emails belonging to user.
            string query = string.Format(
                @"EXEC Mail.Email_GetByUser @username = '{0}';",
                username
            );
            FillRepository(query);
        }

        protected override void CreateEval(DEmail creating){
            SqlCommand command = new SqlCommand("Mail.Email_Create");
            command.AddParam("Title", creating.Title);
            command.AddParam("Body", creating.Body);
            command.AddParam("Sender", creating.Sender);
            command.AddParam("Recipient", creating.Recipient);

            //The entry is created in the database and email is assigned resulting key.
            creating.key = ExecStoredProcedure(command);

            base.CreateEval(creating);      //Entry is created in main memory collection.
        }

        protected override void UpdateEval(DEmail updating){
            SqlCommand command = new SqlCommand("Mail.Email_Update");
            command.AddParams( 
                new Param("Email_ID", updating.Email_ID),
                new Param("Title", updating.Title),
                new Param("Body", updating.Body),
                new Param("Sender", updating.Sender),
                new Param("Recipient", updating.Recipient)
            );

            ExecNonReader(command);             //The entry is updated in the database.

            base.UpdateEval(updating);      //Entry is created in main memory collection.
        }

        protected override void DeleteEval(DEmail deleting){
            SqlCommand command = new SqlCommand("Mail.Email_Delete");
            command.AddParam("Email_ID", deleting.Email_ID);

            ExecNonReader(command);             //The entry is removed from the database.

            base.DeleteEval(deleting);      //Entry is removed from main memory collection.
        }
    }
}
