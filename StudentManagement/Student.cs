using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement
{
    class Student
    {
        private string id;
        private string name;
        private string DoB;
        private string email;
        private string address;
        private string batch;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Batch { get => batch; set => batch = value; }
        public string DateOfBirth { 
            get {
                return DoB;
            } 
            set => DoB = value; 
        }
    }
}
