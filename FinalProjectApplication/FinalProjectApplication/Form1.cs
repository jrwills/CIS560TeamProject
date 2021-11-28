using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //added by me

namespace FinalProjectApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";
            SqlConnection connect = new SqlConnection(connectionString);
            try
            {
                connect.Open();
                label1.Text = "i am connected";
            }
            catch (Exception ex)
            {
                label1.Text = "ERROR did not connect";
                connect.Close();
            }
        }
    }
}
