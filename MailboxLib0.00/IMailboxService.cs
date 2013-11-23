/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   IMailboxService.cs
 |  Purpose:    Declares the main services provided by the mailbox library.
 |  Note:       This project can is ready to me made into a web service at a later time.
 |  Date:       October 14th 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using System.Collections.Generic;
using System.ServiceModel;
using MailboxLib.Base;
using MailboxLib.Data.Entities;
using MailboxLib.Presentation;

namespace MailboxLib{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IMailboxService{
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Email_GetByUser
         |  Purpose:    Retrieves a list of emails belonging to a user.
         |  Param:      username            The owner of all targetted emails.
         |  Return:     IEnumerable<DEmail> The collection of emails belonging to user.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DEmail> Email_GetByUser(string username);

        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Email_Create
         |  Purpose:    Creates an email and returns the resulting collection.
         |  Param:      username            The owner of the targetted email collection.
         |              creating            The email being created.
         |  Return:     IEnumerable<DEmail> Resulting collection of emails.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DEmail> Email_Create(DEmail creating, string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Email_Update
         |  Purpose:    Updates an email and returns the resulting collection.
         |  Param:      username            The owner of the targetted email.
         |              updating            The email being updated.
         |  Return:     IEnumerable<DEmail> Resulting collection of emails.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DEmail> Email_Update(DEmail updating, string username);
        /*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
         |  Function:   Email_Delete
         |  Purpose:    Deletes an email and returns the resulting collection.
         |  Param:      username            The owner of the targetted email.
         |              deleting            The email being deleted.
         |  Return:     IEnumerable<DEmail> Resulting collection of emails.
         +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        */
        [OperationContract]
        IEnumerable<DEmail> Email_Delete(DEmail deleting, string username);
    }
}
