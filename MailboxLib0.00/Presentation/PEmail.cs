using Repository.Presentation;
namespace MailboxLib.Presentation{
    public class PEmail : MailboxLib.Base.Email, IPresentationUnit{
        public virtual void Format() {
            if(Title == null){
                Title = string.Empty;
            }
            if (Body == null){
                Body = string.Empty;
            }
            if (Recipient == null){
                Recipient = string.Empty;
            }
            if (Sender == null){
                Sender = string.Empty;
            }
        }
    }
}
