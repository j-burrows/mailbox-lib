/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BEmail.cs
 |  Purpose:    Defines the business logic of an email.
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Business;
using Repository.Business.Protocols;
namespace MailboxLib.Business{
    public class BEmail : MailboxLib.Presentation.PEmail, IBusinessUnit{
        public readonly ProtocolStack Email_ID_Rules = ProtocolStack.ForKey("Email_ID");
        public readonly ProtocolStack Title_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = true, maxLength = 32 }, "Title");
        public readonly ProtocolStack Body_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 1024 }, "Body");
        public readonly ProtocolStack Recipient_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 32 }, "Recipient");
        public readonly ProtocolStack Sender_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 32 }, "Sender");

        public virtual bool CreateValid() {
            bool isValid = true;
            isValid = Email_ID_Rules.Create.passes(Email_ID) && isValid;
            isValid = Title_Rules.Create.passes(Title) && isValid;
            isValid = Body_Rules.Create.passes(Body) && isValid;
            isValid = Recipient_Rules.Create.passes(Recipient) && isValid;
            isValid = Sender_Rules.Create.passes(Sender) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid(){
            bool isValid = true;
            isValid = Email_ID_Rules.Create.passes(Email_ID) && isValid;
            isValid = Title_Rules.Create.passes(Title) && isValid;
            isValid = Body_Rules.Create.passes(Body) && isValid;
            isValid = Recipient_Rules.Create.passes(Recipient) && isValid;
            isValid = Sender_Rules.Create.passes(Sender) && isValid;
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
