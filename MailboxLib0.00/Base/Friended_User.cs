/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   Friended_User.cs
 |  Purpose:    Defines information about a friended user.
 |  Author:     Jonathan Burrows
 |  Date:       October 14th 2013
 +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
*/
namespace MailboxLib.Base{
    public class Friended_User{
        public virtual int Friended_User_ID { get; set; }
        public virtual string Author_Name { get; set; }
        public virtual string username { get; set; }
    }
}
