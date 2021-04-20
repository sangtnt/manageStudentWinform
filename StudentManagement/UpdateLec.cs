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
            Lecturer lecturer = DataProvider.Instance.findLecturerById(id);
            idtxt.Text = lecturer.Id;
            nametxt.Text = lecturer.Name;
            emailtxt.Text = lecturer.Email;
            addresstxt.Text = lecturer.Address;
            deptxt.Text = lecturer.Department;
            DateTime dt = DateTime.ParseExact(
            lecturer.DateOfBirth, "dd-MM-yyyy",
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
            Lecturer lecturer = new Lecturer();
            lecturer.Id = idtxt.Text;
            lecturer.Name = nametxt.Text;
            lecturer.DateOfBirth = dobtxt.Value.ToString("dd-MM-yyyy");
            lecturer.Address = addresstxt.Text;
            lecturer.Email = emailtxt.Text;
            lecturer.Department = deptxt.Text;
            DataProvider.Instance.updateLecturer(lecturer);
            this.Close();
        }
    }
}
