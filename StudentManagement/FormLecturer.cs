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
        MongoClientSettings settings = new MongoClientSettings();
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
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("StudentManagement");
            var collection = db.GetCollection<Lecturer>("lecturer");
            var query = collection.AsQueryable<Lecturer>().ToList();
            LecTable.DataSource = query;
        }
        private void DeleteLecById(string id)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("StudentManagement");
            var collection = db.GetCollection<Lecturer>("lecturer");
            collection.DeleteOne(Builders<Lecturer>.Filter.Eq("_id", id));
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
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("StudentManagement");
            var collection = db.GetCollection<Lecturer>("lecturer");
            var builder = Builders<Lecturer>.Filter;
            var filter = builder.Regex("_id", search);
            List<Lecturer> results = collection.Find(filter).ToList();
            LecTable.DataSource = results;
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
