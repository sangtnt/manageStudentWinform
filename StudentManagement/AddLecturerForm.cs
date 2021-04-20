using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;

namespace StudentManagement
{
    public partial class AddLecturerForm : Form
    {
        public AddLecturerForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void lecSubmit_Click(object sender, EventArgs e)
        {
            if (idtxt.Text == "")
            {
                MessageBox.Show("Please fill ID");
                return;
            }
            if (idtxt.Text.Length != 8)
            {
                MessageBox.Show("Length of ID must be 8 charcters");
                return;
            }
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
            Lecturer newLec = new Lecturer();
            newLec.Id = idtxt.Text;
            newLec.Name = nametxt.Text;
            newLec.Address = addresstxt.Text;
            if (!CheckValidation.checkEmail(emailtxt.Text))
            {
                MessageBox.Show("Please enter a valid email!");
                return;
            }
            newLec.Email = emailtxt.Text;
            newLec.DateOfBirth = DoBtxt.Value.ToString("dd-MM-yyyy");
            newLec.Department = deptxt.Text;
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("StudentManagement");
            var collection = db.GetCollection<Lecturer>("lecturer");
            collection.InsertOne(newLec);
            this.Close();
        }
    }
}
