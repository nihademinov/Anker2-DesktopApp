using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Anker2_DesktopApp
{
    internal class User
    {

        private string? _Surname;
        private string? _Name;
        private string? _Phone;
        private string? _BirthDate;
        private string? _Email;

        [JsonConstructor]
        public User(string? surname, string? name, string? phone, string? birthDate,string? email)
        {
            _Surname = surname;
            _Name = name;
            _Phone = phone;
            _BirthDate = birthDate;
            _Email = email; 
        }

        public string? Property_Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }

        public string? Property_Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
       

        public string? Property_Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
       
        public string? Property_Date
        {
            get { return _BirthDate; }
            set { _BirthDate = value; }
        }
        public string? Property_Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public override string ToString() => $"User:{Property_Name} {Property_Surname}";
    }
}
