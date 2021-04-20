using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement
{
    class Lecturer
    {
        private string id;
        private string name;
        private string DoB;
        private string email;
        private string address;
        private string department;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DateOfBirth { get => DoB; set => DoB = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Department { get => department; set => department = value; }
    }
}
