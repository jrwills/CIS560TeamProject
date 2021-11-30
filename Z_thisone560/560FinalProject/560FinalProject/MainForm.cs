/*
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

        /// <summary>
        /// Should be everytime the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            tableLabel.Text = "Health Database (All personnel)";
        }

        /// <summary>
        /// 
        /// </summary>
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

        private void ForQueries(string query)
        {
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

        //------------------------------------- CLICK EVENTS ---------------------------------------------------------//

        /// <summary>
        /// Opens the AddForm WinForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPerson_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Show(); //originally showdialog
        }

        /// <summary>
        /// Display all donors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void queryButton_Click(object sender, EventArgs e)
        {
            ForQueries("SELECT D.DonorID, PD.FirstName, PD.LastName, D.BloodType, PD.Gender FROM Final.Donor D INNER JOIN Final.PersonalDetails PD ON D.DonorID = PD.UniqueID ORDER BY FirstName ASC");
            tableLabel.Text = "Health Database (Donors)";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void patientButton_Click(object sender, EventArgs e)
        {
            ForQueries("SELECT P.PatientID, PD.FirstName, PD.LastName, P.BloodType, PD.Gender FROM Final.Patient P INNER JOIN Final.PersonalDetails PD ON P.PatientID = PD.UniqueID ORDER BY PD.FirstName ASC");
            tableLabel.Text = "Health Database (Patients)";
        }

        /// <summary>
        /// Search for INDIVIDUAL Personnel only?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            string s = searchText.Text; //Must be exact im guessing :(
            if(tableLabel.Text.Contains("Donors"))
            {
                ForQueries("SELECT PD.FirstName, PD.LastName, D.BloodType, PD.Gender FROM Final.Donor D INNER JOIN Final.PersonalDetails PD ON D.DonorID = PD.UniqueID WHERE D.DonorID = " + s + " ORDER BY PD.FirstName ASC");
                tableLabel.Text = "Health Database ()"; //                                                                                      NVAR 32 = NVAR 32
            }
            else if(tableLabel.Text.Contains("Patients"))
            {
                ForQueries("");
                tableLabel.Text = "Health Database ()";
            }
            else
            {
                MessageBox.Show("Please enter a valid LastName");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void medicalButton_Click(object sender, EventArgs e)
        {
            ForQueries("SELECT MP.MedicalPersonnelID, PD.FirstName, PD.LastName, PD.Gender FROM Final.MedicalPersonnel MP INNER JOIN Final.PersonalDetails PD ON MP.MedicalPersonnelID = PD.UniqueID ORDER BY PD.FirstName ASC");
            tableLabel.Text = "Health Database (Medical personnel)";
        }

        /// <summary>
        /// Displays the initial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void allButton_Click(object sender, EventArgs e)
        {
            ForQueries("SELECT * FROM Final.PersonalDetails");
            tableLabel.Text = "Health Database (All personnel)";
        }


        /// <summary>
        /// Query to Only display Blood Donation database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void q1Button_Click(object sender, EventArgs e)
        {
            ForQueries("SELECT * FROM Final.BloodDonation");
            tableLabel.Text = "Health Database (Blood Donations)";
        }

        //------------------------------------- Auxillary Methods ---------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string RetrieveGender(string s)
        {
            return s;
        }
    }
}
