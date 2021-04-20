using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Linq;

namespace StudentManagement
{
    public partial class FormLecturer : UserControl
    {
        public FormLecturer()
        {
            InitializeComponent();
            this.Top = 30;
            LoadData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddLecturerForm addLec = new AddLecturerForm();
            addLec.ShowDialog();
            LoadData();
        }
        public void LoadData()
        {
            List<Lecturer> lecturers = DataProvider.Instance.findAllLecturers();
            LecTable.DataSource = lecturers;
        }
        private void DeleteLecById(string id)
        {
            DataProvider.Instance.deleteLecturerById(id);
        }
        private void LecTable_SelectionChanged(object sender, EventArgs e)
        {
            if (LecTable.SelectedRows.Count > 0)
            {
                if (LecTable.SelectedRows.Count == 1)
                {
                    LecUpdate.Enabled = true;
                }
                else
                {
                    LecUpdate.Enabled = false;
                }
                lecDelete.Enabled = true;
            }
            else
            {
                LecUpdate.Enabled = false;
                lecDelete.Enabled = false;
            }
        }

        private void StuDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in LecTable.SelectedRows)
            {
                DeleteLecById(row.Cells[0].Value.ToString());
            }
            LoadData();
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
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
            List<Lecturer> lecturers = DataProvider.Instance.findLecturerLikeId(search);
            LecTable.DataSource = lecturers;
        }

        private void LecUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in LecTable.SelectedRows)
            {
                UpdateLec up = new UpdateLec(row.Cells[0].Value.ToString());
                up.ShowDialog();
            }
            LoadData();
        }
    }
}
