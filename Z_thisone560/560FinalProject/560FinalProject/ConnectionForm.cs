/*
 * File: ConnectionForm.cs
 * Purpose: Confirm connection to the SQL server
 */
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

namespace _560FinalProject
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
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
                MessageBox.Show("You are connected");
                MainForm mf = new MainForm();
                mf.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Could not connect");
                connect.Close();
            }
        }
    }
}
