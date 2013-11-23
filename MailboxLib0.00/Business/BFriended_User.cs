/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   BFriended_User.cs
 |  Purpose:    Defines the business logic of a friended user.
 |  Date:       October 14th 2013
*/// --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
using Repository.Business;
namespace MailboxLib.Business{
    public class BFriended_User : MailboxLib.Presentation.PFriended_User, IBusinessUnit{
        public ReadsafeDictionary ValidationErrors { get; set; }
        public BFriended_User() :base(){
            ValidationErrors = new ReadsafeDictionary();
        }

        public virtual bool CreateValid(){
            bool isValid = true;
            if (Author_Name == null){
                ValidationErrors["Author_Name"] = "Author name cannot be empty.";
                isValid = false;
            }
            else if (Author_Name.Length > 32){
                ValidationErrors["Author_Name"] = "Author name cannot exceed 32 characters.";
                isValid = false;
            }
            if (username == null){
                ValidationErrors["username"] = "username cannot be empty.";
                isValid = false;
            }
            else if (username.Length > 32){
                ValidationErrors["username"] = "username cannot exceed 32 characters.";
                isValid = false;
            }
            return isValid;
        }

        public virtual bool UpdateValid(){
            bool isValid = true;
            if (Author_Name != null && Author_Name.Length > 32){
                ValidationErrors["Author_Name"] = "Author name cannot exceed 32 characters.";
                isValid = false;
            }
            if (username != null && username.Length > 32){
                ValidationErrors["username"] = "username cannot exceed 32 characters.";
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
