using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //protected virtual string PasswordStored
        //{
        //    get;
        //    set;
        //}


        //[NotMapped]
        //public string Password
        //{
        //    get { return Decrypt(PasswordStored); }
        //    set { PasswordStored = Encrypt(value); }
        //}


    }
}
