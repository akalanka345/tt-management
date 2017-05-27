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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AKALANKA-PC;Initial Catalog=TTMgmntSystem;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where user_name ='"+textBox1.Text +"'and password ='"+textBox2.Text+"' ",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("Select type From Login where user_name ='" + textBox1.Text + "'and password ='" + textBox2.Text + "' ", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                    if (dt1.Rows[0][0].ToString() == "Admin")
                    {
                        this.Hide();
                        Admin admin = new Admin();
                        admin.Show();
                    }

                    if (dt1.Rows[0][0].ToString() == "User")
                    {
                        this.Hide();
                        User user = new User();
                        user.Show();
                    }

                       
            }
            else
            {
                MessageBox.Show("Invalid user name and Password");

            }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
        }
    }
}
