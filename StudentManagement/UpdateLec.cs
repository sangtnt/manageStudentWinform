using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;

namespace StudentManagement
{
    public partial class UpdateLec : Form
    {
        public UpdateLec()
        {
            InitializeComponent();
        }
        public UpdateLec(string id)
        {
            InitializeComponent();
            this.CenterToParent();
            displayLecturer(id);
            this.MaximizeBox = false;
        }
        private void displayLecturer(string id)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("StudentManagement");
            var collection = db.GetCollection<Lecturer>("lecturer");
            var lec = collection.Find(Builders<Lecturer>.Filter.Eq("_id", id)).ToList();
            idtxt.Text = lec[0].Id;
            nametxt.Text = lec[0].Name;
            emailtxt.Text = lec[0].Email;
            addresstxt.Text = lec[0].Address;
            deptxt.Text = lec[0].Department;
            DateTime dt = DateTime.ParseExact(
            lec[0].DateOfBirth, "dd-MM-yyyy",
            CultureInfo.InvariantCulture);
            dobtxt.Value = dt;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "")
            {
                MessageBox.Show("Please fill Name");
                return;
            }
            if (emailtxt.Text == "")
            {
                MessageBox.Show("Please fill Email");
                return;
            }
            if (addresstxt.Text == "")
            {
                MessageBox.Show("Please fill Address");
                return;
            }
            if (deptxt.Text == "")
            {
                MessageBox.Show("Please fill Department of lecturer");
                return;
            }
            if (!CheckValidation.checkEmail(emailtxt.Text))
            {
                MessageBox.Show("Please enter a valid email!");
                return;
            }
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("StudentManagement");
            var collection = db.GetCollection<Lecturer>("lecturer");
            var filter = Builders<Lecturer>.Filter.Eq("_id", idtxt.Text);
            var update = Builders<Lecturer>.Update.Set("Name", nametxt.Text);
            collection.UpdateOne(filter, update);
            update = Builders<Lecturer>.Update.Set("Address", addresstxt.Text);
            collection.UpdateOne(filter, update);
            update = Builders<Lecturer>.Update.Set("Email", emailtxt.Text);
            collection.UpdateOne(filter, update);
            update = Builders<Lecturer>.Update.Set("Department", deptxt.Text);
            collection.UpdateOne(filter, update);
            update = Builders<Lecturer>.Update.Set("DateOfBirth", dobtxt.Value.ToString("dd-MM-yyyy"));
            collection.UpdateOne(filter, update);
            this.Close();
        }
    }
}
