/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   DEmail.cs
 |  Purpose:    Defines the data access logic of an email.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Data;
using Repository.Helpers;
namespace MailboxLib.Data.Entities{
    public class DEmail : MailboxLib.Business.BEmail, IDataUnit{
        public int key {
            get { return Email_ID; }
            set { Email_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(System.Data.DataRow row){
            Email_ID = row["Email_ID"].ToInt();
            Title = row["Title"].ToStr();
            Body = row["Body"].ToStr();
            Recipient = row["Recipient"].ToStr();
            Sender = row["Sender"].ToStr();
        }

        public override bool Equivilant(global::Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DEmail>(comparing);
        }

        public void Scrub() {
            //All string members are scrubbed.
            Title = Title.Scrub();
            Body = Body.Scrub();
            Recipient = Recipient.Scrub();
            Sender = Sender.Scrub();
        }
    }
}
