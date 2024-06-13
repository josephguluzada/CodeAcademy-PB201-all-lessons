using ClassTask.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    public class User
    {
        private string _password;
        private static int _counter;
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password 
        { 
            get => _password; 
            set
            {
                if (Helper.CheckPassword(value))
                {
                    _password = value;
                }
            } 
        } // min 8 Boyuk herf 1reqem 1 simvol olmalidir

        static User()
        {
            _counter = 0;
        }

        public User(string userName, string password)
        {
            _counter++;
            Id = _counter;
            Username = userName;
            Password = password;
        }
    }
}
