using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.TopLevel = false;
            staff.AutoScroll = true;
            staff.MdiParent = this;
            staff.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            staff.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classrooms cls = new Classrooms();
            cls.TopLevel = false;
            cls.AutoScroll = true;
            cls.MdiParent = this;
            cls.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cls.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timetable time = new Timetable();
            time.Show();

        }
    }
}
