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
    public partial class UpdateStu : Form
    {
        public UpdateStu()
        {
            InitializeComponent();
        }
        public UpdateStu(string id)
        {
            InitializeComponent();
            this.CenterToParent();
            displayStudent(id);
            this.MaximizeBox = false;
            this.CenterToParent();
        }
        private void displayStudent(string id)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("StudentManagement");
            var collection = db.GetCollection<Student>("student");
            var std = collection.Find(Builders<Student>.Filter.Eq("_id", id)).ToList();
            idtxt.Text = std[0].Id;
            nametxt.Text = std[0].Name;
            emailtxt.Text = std[0].Email;
            addresstxt.Text = std[0].Address;
            batchtxt.Text = std[0].Batch;
            DateTime dt = DateTime.ParseExact(
            std[0].DateOfBirth, "dd-MM-yyyy",
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
            if (batchtxt.Text == "")
            {
                MessageBox.Show("Please fill Batch of student");
                return;
            }
            if (!CheckValidation.checkEmail(emailtxt.Text))
            {
                MessageBox.Show("Please enter a valid email!");
                return;
            }
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("StudentManagement");
            var collection = db.GetCollection<Student>("student");
            var filter = Builders<Student>.Filter.Eq("_id", idtxt.Text);
            var update = Builders<Student>.Update.Set("Name", nametxt.Text);
            collection.UpdateOne(filter, update);
            update = Builders<Student>.Update.Set("Address", addresstxt.Text);
            collection.UpdateOne(filter, update);
            update = Builders<Student>.Update.Set("Email", emailtxt.Text);
            collection.UpdateOne(filter, update);
            update = Builders<Student>.Update.Set("Batch", batchtxt.Text);
            collection.UpdateOne(filter, update);
            update = Builders<Student>.Update.Set("DateOfBirth", dobtxt.Value.ToString("dd-MM-yyyy"));
            collection.UpdateOne(filter, update);
            this.Close();
        }
    }
}
