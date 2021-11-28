﻿/*
 * File: MainForm.cs
 * Purpose: Accomadate all needs of the "user" a.k.a hospital personnel
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitialQuery();
        }

        private void InitialQuery()
        {
            string query = "SELECT * FROM Final.PersonalDetails";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TestDatabase2;Integrated Security=True";
            //SqlConnection connect = new SqlConnection(connectionString);

            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand myCommand = new SqlCommand(query, myConnection))
                {
                    myCommand.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(myCommand))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataForm.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.ShowDialog();
        }
    }
}
