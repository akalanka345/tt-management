using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AKALANKA-PC;Initial Catalog=TTMgmntSystem;Integrated Security=True");
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select SubId from Subjects", con);
            
            DataTable ds = new DataTable();
            ad.Fill(ds);

            BindingSource bsource = new BindingSource();
            bsource.DataSource = ds;

            //dataGridView1.DataSource = bsource;
            ad.Update(ds);
        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTMgmntSystemDataSet1.Lecturers' table. You can move, or remove it, as needed.
            this.lecturersTableAdapter.Fill(this.tTMgmntSystemDataSet1.Lecturers);
            // TODO: This line of code loads data into the 'tTMgmntSystemDataSet.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.tTMgmntSystemDataSet.Subjects);

        }
    }
}
