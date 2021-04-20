using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.greenwich;
            this.Dock = DockStyle.Fill;
        }
    }
}
