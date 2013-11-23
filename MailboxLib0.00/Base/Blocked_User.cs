/*-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
 |  Filename:   Blocked_User.cs
 |  Purpose:    Defines information about a blocked user.
 |  Author:     Jonathan Burrows
 |  Date:       October 14th 2013
 +-- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
*/
namespace MailboxLib.Base{
    public class Blocked_User{
        public virtual int Blocked_User_ID { get; set; }
        public virtual string Author_Name { get; set; }
        public virtual string username { get; set; }
    }
}
