using Repository.Presentation;
namespace MailboxLib.Presentation{
    public class PFriended_User : MailboxLib.Base.Friended_User, IPresentationUnit{
        public virtual void Format(){
            if (Author_Name == null){
                Author_Name = string.Empty;
            }
            if (username == null){
                username = string.Empty;
            }
        }
    }
}
