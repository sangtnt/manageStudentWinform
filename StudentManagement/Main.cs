using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace StudentManagement
{
    //Main class
    public partial class MainMenu : Form
    {
        ToolStripMenuItem homeItem = new ToolStripMenuItem("Home");
        ToolStripMenuItem studentItem = new ToolStripMenuItem("Student");
        ToolStripMenuItem lectureItem = new ToolStripMenuItem("Lecturer");
        public MainMenu()
        {
            InitializeComponent();
            this.ConfigForm();
            this.LoadMenu();
            Home home = new Home();
            home.Name = "homeControl";
            this.Controls.Add(home);
            homeItem.ForeColor = Color.DarkGray;
        }
        //Load Main Menu
        public void LoadMenu()
        {
            //Init MenuStrip
            MenuStrip menu = new MenuStrip();
            menu.BackColor = Color.Black;
            menu.Text = "Main Menu";
            this.MainMenuStrip = menu;
            menu.Renderer = new MyRenderer();
            this.Controls.Add(menu);
            //Generate menu items
            homeItem.Text = "Home";
            homeItem.ForeColor = Color.White;
            homeItem.Click += HomeItem_MouseClick;

            studentItem.Text = "Student";
            studentItem.ForeColor = Color.White;
            studentItem.Click += StudentItem_MouseClick;

            lectureItem.Text = "Lecturer";
            lectureItem.ForeColor = Color.White;
            lectureItem.Click += LectureItem_MouseClick;
            //Add items to main menu
            menu.Items.Add(homeItem);
            menu.Items.Add(studentItem);
            menu.Items.Add(lectureItem);
        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = e.Item.Selected ? Color.LightGray : Color.Black;
                using (SolidBrush brush = new SolidBrush(c))
                    e.Graphics.FillRectangle(brush, rc);
            }
        }
        //Handle Home item Click
        private void HomeItem_MouseClick(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Name = "homeControl";
            this.Controls.RemoveByKey("homeControl");
            this.Controls.RemoveByKey("studentControl");
            this.Controls.RemoveByKey("lecControl");
            this.Controls.Add(home);
            homeItem.ForeColor = Color.DarkGray;
            lectureItem.ForeColor = Color.White;
            studentItem.ForeColor = Color.White;
        }
        //Handle Student item Click
        private void StudentItem_MouseClick(object sender, EventArgs e)
        {
            FormStudent stu = new FormStudent();
            stu.Name = "studentControl";
            this.Controls.RemoveByKey("homeControl");
            this.Controls.RemoveByKey("studentControl");
            this.Controls.RemoveByKey("lecControl");
            this.Controls.Add(stu);
            homeItem.ForeColor = Color.White;
            lectureItem.ForeColor = Color.White;
            studentItem.ForeColor = Color.DarkGray;

        }
        //Handle Lecture item Click
        private void LectureItem_MouseClick(object sender, EventArgs e)
        {
            FormLecturer lec = new FormLecturer();
            lec.Name = "lecControl";
            this.Controls.RemoveByKey("homeControl");
            this.Controls.RemoveByKey("studentControl");
            this.Controls.RemoveByKey("lecControl");
            this.Controls.Add(lec);
            homeItem.ForeColor = Color.White;
            lectureItem.ForeColor = Color.DarkGray;
            studentItem.ForeColor = Color.White;
        }
        //Set properties for main form
        private void ConfigForm()
        {
            this.CenterToScreen();
            this.Text = "Student Management";
            this.MaximizeBox = false;
        }
    }
}
