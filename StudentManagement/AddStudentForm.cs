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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
            this.Text = "Add new student";
            IDCombobox.Items.Add("GT");
            IDCombobox.Items.Add("GC");
            this.CenterToParent();
            this.MaximizeBox = false;
            DoBtxt.Format = DateTimePickerFormat.Custom;
            DoBtxt.CustomFormat = "dd MMM yyyy";
        }
        private void IDCombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void submitStu_Click(object sender, EventArgs e)
        {
            if (IDCombobox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Standard header for ID!");
                return;
            }
            if (Idtxt.Text == "")
            {
                MessageBox.Show("Please fill ID");
                return;
            }
            if (Nametxt.Text == "")
            {
                MessageBox.Show("Please fill Name");
                return;
            }
            if (Emailtxt.Text == "")
            {
                MessageBox.Show("Please fill Email");
                return;
            }
            if (Addresstxt.Text == "")
            {
                MessageBox.Show("Please fill Address");
                return;
            }
            if (Batchtxt.Text == "")
            {
                MessageBox.Show("Please fill Batch of student");
                return;
            }
            Student newStu = new Student();
            newStu.Id = IDCombobox.Text + Idtxt.Text;
            newStu.Name = Nametxt.Text;
            newStu.Address = Addresstxt.Text;
            if (!CheckValidation.checkEmail(Emailtxt.Text))
            {
                MessageBox.Show("Please enter a valid email!");
                return;
            }
            newStu.Email = Emailtxt.Text;
            newStu.DateOfBirth = DoBtxt.Value.ToString("dd-MM-yyyy");
            newStu.Batch = Batchtxt.Text;
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("StudentManagement");
            var collection = db.GetCollection<Student>("student");
            var results = collection.Find(x => x.Id == IDCombobox.Text + Idtxt.Text).ToList();
            if (results.Count > 0)
            {
                MessageBox.Show("Id is not available!");
                return;
            }
            collection.InsertOne(newStu);
            this.Close();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
