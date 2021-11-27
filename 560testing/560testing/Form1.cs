using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; //added by me
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _560testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(localDB)\MSSQLLocalDB;Integrated Security=True");
            
            try
            {
                connect.Open();
                label1.Text = "yay";
            }
            catch (Exception ex)
            {
                label1.Text = "oops" + ex.Message;
                connect.Close();
            }
        }
    }
}
