using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement
{
    //Singleton design pattern
    class DataProvider
    {
        //static instance variable
        private static DataProvider instance;

        //connection
        private IMongoCollection<Student> studentCollection;
        private IMongoCollection<Lecturer> lecturerCollection;
        //get set method
        public static DataProvider Instance {
            get { 
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance; 
            }
        }
        //not allow to be init outside
        private DataProvider()
        {
            LoadDatabase();
        }
        //connect database
        private void LoadDatabase()
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("StudentManagement");
            this.studentCollection = db.GetCollection<Student>("student");
            this.lecturerCollection = db.GetCollection<Lecturer>("lecturer");
        }
        //Student mode functions
        public List<Student> findAllStudents()
        {
            return studentCollection.AsQueryable<Student>().ToList();
        }
        public List<Student> findStudentLikeId(string id)
        {
            var builder = Builders<Student>.Filter;
            var filter = builder.Regex("_id", id);
            return studentCollection.Find(filter).ToList();
        }
        public Student findStudentById(string id)
        {
            var filter = Builders<Student>.Filter.Eq("_id", id);
            if (studentCollection.Find(filter).ToList().Count==0)
            {
                return null;
            }
            return studentCollection.Find(filter).ToList()[0];
        }
        public void updateStudent(Student student)
        {
            studentCollection.ReplaceOne(std => std.Id == student.Id, student);
        }
        public void deleteStudentById(string id)
        {
            studentCollection.DeleteOne(Builders<Student>.Filter.Eq("_id", id));
        }
        public void insertStudent(Student student)
        {
            studentCollection.InsertOne(student);
        }

        //Lecturer model functions
        public List<Lecturer> findAllLecturers()
        {
            return lecturerCollection.AsQueryable<Lecturer>().ToList();
        }
        public Lecturer findLecturerById(string id)
        {
            var filter = Builders<Lecturer>.Filter.Eq("_id", id);
            if (lecturerCollection.Find(filter).ToList().Count == 0)
            {
                return null;
            }
            return lecturerCollection.Find(filter).ToList()[0];
        }
        public void updateLecturer(Lecturer lecturer)
        {
            lecturerCollection.ReplaceOne(lec => lec.Id == lecturer.Id, lecturer);
        }
        public void deleteLecturerById(string id)
        {
            lecturerCollection.DeleteOne(Builders<Lecturer>.Filter.Eq("_id", id));
        }
        public List<Lecturer> findLecturerLikeId(string id)
        {
            var builder = Builders<Lecturer>.Filter;
            var filter = builder.Regex("_id", id);
            return lecturerCollection.Find(filter).ToList();
        }
        public void insertLecturer(Lecturer lecturer)
        {
            lecturerCollection.InsertOne(lecturer);
        }
    }
}
