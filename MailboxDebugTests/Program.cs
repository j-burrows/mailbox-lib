using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MailboxLib;
using MailboxLib.Base;
using MailboxLib.Business;
using MailboxLib.Data.Entities;
using Repository.Business.Protocols;

namespace MailboxDebugTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Act: the blocked user is checked if it is update valid.
            /*
            Repository.Configuration.connString = "Server=localhost;Database=ApplicationData;Trusted_Connection=True;";
            IMailboxService service = new MailboxService();
            IEnumerable<Blocked_User> users = service.Blocked_User_Delete(new DBlocked_User{key = 1,username="user", Author_Name="unblocked"}, "user");
            */
        } 
    }
}
