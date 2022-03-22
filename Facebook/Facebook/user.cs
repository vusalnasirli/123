using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook
{
    class User
    {
        public string name;
        public string surname;
        public string email;
        public DateTime Dateofbirth;
        public bool issingle;

        public User()
        {
            name = "vusal";
            surname = "nasirli";
            email = "nvusal.606@gmail.com";
            Dateofbirth = new DateTime(2001);
            issingle = true;
        }
        public User(string name, string surname, string email, DateTime Dateofbirth, bool issingle)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.Dateofbirth = Dateofbirth;
            this.issingle = true;
        }

    }

    
}
