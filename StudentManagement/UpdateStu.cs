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
            Student std = DataProvider.Instance.findStudentById(id);
            idtxt.Text = std.Id;
            nametxt.Text = std.Name;
            emailtxt.Text = std.Email;
            addresstxt.Text = std.Address;
            batchtxt.Text = std.Batch;
            DateTime dt = DateTime.ParseExact(
            std.DateOfBirth, "dd-MM-yyyy",
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
            
            Student student = new Student();
            student.Id = idtxt.Text;
            student.Name = nametxt.Text;
            student.Email = emailtxt.Text;
            student.Address = addresstxt.Text;
            student.Batch = batchtxt.Text;
            student.DateOfBirth = dobtxt.Value.ToString("dd-MM-yyyy");
            DataProvider.Instance.updateStudent(student);
            this.Close();
        }
    }
}
