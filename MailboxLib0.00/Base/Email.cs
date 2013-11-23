/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   Email.cs
 |  Purpose:    Defines what an email and its members.
 |  Author:     Jonathan Burrows
 |  Date:       October 14th 2013
 +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
*/
namespace MailboxLib.Base{
    public class Email{
        public virtual int Email_ID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Body { get; set; }
        public virtual string Recipient { get; set; }
        public virtual string Sender { get; set; }
    }
}
