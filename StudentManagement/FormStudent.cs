using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace StudentManagement
{
    public partial class FormStudent : UserControl
    {
        public FormStudent()
        {
            InitializeComponent();
            this.Top = 30;
            LoadData();
        }
        public void LoadData()
        {
            var students = DataProvider.Instance.findAllStudents();
            StuTable.DataSource = students;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddStudentForm stuForm = new AddStudentForm();
            stuForm.ShowDialog();
            LoadData();
        }
        private void DeleteStuById(string id)
        {
            DataProvider.Instance.deleteStudentById(id);            
        }
        private void StuTable_SelectionChanged(object sender, EventArgs e)
        {
            if (StuTable.SelectedRows.Count > 0)
            {
                if (StuTable.SelectedRows.Count == 1)
                {
                    StuUpdate.Enabled = true;
                }
                else
                {
                    StuUpdate.Enabled = false;
                }
                StuDelete.Enabled = true;
            }
            else
            {
                StuUpdate.Enabled = false;
                StuDelete.Enabled = false;
            }
        }

        private void StuDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in StuTable.SelectedRows)
            {
                DeleteStuById(row.Cells[0].Value.ToString());
            }
            LoadData();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if(SearchBox.Text == "")
            {
                LoadData();
            }
            else
            {
                Search(SearchBox.Text);
            }
        }
        private void Search(string search)
        {
            List<Student> students = DataProvider.Instance.findStudentLikeId(search);
            StuTable.DataSource = students;
        }
        private void StuUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in StuTable.SelectedRows)
            {
                UpdateStu up = new UpdateStu(row.Cells[0].Value.ToString());
                up.ShowDialog();
            }
            LoadData();
        }
    }
}
