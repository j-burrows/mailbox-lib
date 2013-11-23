/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   MailboxService.cs
 |  Purpose:    Defines the main services provided by the mailbox library.
 |  Date:       October 14th 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using MailboxLib.Base;
using MailboxLib.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using Repository.Data;
using MailboxLib.Factory;
using MailboxLib.Presentation;
namespace MailboxLib {
    public class MailboxService : IMailboxService{
        public IEnumerable<DEmail> Email_GetByUser(string username) {
            return RepositoryFactory.Instance.Construct<DEmail>(username);
        }

        public IEnumerable<DEmail> Email_Create(DEmail creating, string username) {
            IDataRepository<DEmail> emails = 
                RepositoryFactory.Instance.Construct<DEmail>(username);
            emails.Create(creating);

            return emails;
        }

        public IEnumerable<DEmail> Email_Update(DEmail updating, string username){
            IDataRepository<DEmail> emails = 
                RepositoryFactory.Instance.Construct<DEmail>(username);
            emails.Update(updating);

            return emails;
        }

        public IEnumerable<DEmail> Email_Delete(DEmail deleting, string username){
            IDataRepository<DEmail> emails = 
                RepositoryFactory.Instance.Construct<DEmail>(username);
            emails.Delete(deleting);

            return emails;
        }

    }
}