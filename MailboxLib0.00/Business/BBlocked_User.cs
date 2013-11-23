/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BBlocked_User.cs
 |  Purpose:    Defines the business logic of a blocked user.
 |  Date:       October 14th 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Business;
using Repository.Business.Protocols;
namespace MailboxLib.Business{
    public class BBlocked_User : MailboxLib.Presentation.PBlocked_User, IBusinessUnit{
        public static readonly ProtocolStack Blocked_User_IDRules = ProtocolStack.ForKey();
        public static readonly ProtocolStack usernameRules = ProtocolStack.ForUsername();
        public static readonly ProtocolStack Author_NameRules = ProtocolStack.WithPremise(
            new Premise { maxLength = 32, nullable = false }, "Author_Name" );

        public ReadsafeDictionary ValidationErrors { get; set; }
        public BBlocked_User() :base(){
            ValidationErrors = new ReadsafeDictionary();
        }

        public virtual bool CreateValid() {
            bool isValid = true;
            if (!Author_NameRules.Create.passes(Author_Name)) {
                isValid = false;
            }
            if (!usernameRules.Create.passes(username)) {
                isValid = false;
            }
            return isValid;
        }

        public virtual bool UpdateValid(){
            bool isValid = true;
            if (!Author_NameRules.Update.passes(Author_Name)){
                isValid = false;
            }
            if (!usernameRules.Update.passes(username)){
                isValid = false;
            }
            return isValid;
        }

        public virtual bool DeleteValid(){
            return true;
        }

        public virtual bool Equivilant(IBusinessUnit comparing){
            return false;
        }
    }
}
