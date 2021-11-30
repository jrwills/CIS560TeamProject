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
            ForQueries(query);
        }

        /// <summary>
        /// Intent to NOT reuse code every method
        /// </summary>
        /// <param name="query"></param>
        private void ForQueries(string query)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TestDatabase2;Integrated Security=True";
            //SqlConnection connect = new SqlConnection(connectionString);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand(query, con))
                {
                    comm.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(comm))
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
                tableLabel.Text = "Health Database ()"; 
            }
            else if(tableLabel.Text.Contains("Patients"))
            {
                ForQueries("");
                tableLabel.Text = "Health Database ()";
            }
            else
            {
                MessageBox.Show("Please enter a valid ID");
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
        /// BLOOD DONATION CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void q1Button_Click(object sender, EventArgs e)
        {
            ForQueries("SELECT * FROM Final.BloodDonation");
            tableLabel.Text = "Health Database (Blood Donations)";
        }

        /// <summary>
        /// QUERY 1 CLICK (display only female donors (later in the past year))
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void query1Button_Click(object sender, EventArgs e)
        {
            ForQueries("SELECT BD.Date, Gender, PD.FirstName, PD.LastName, D.BloodType, BD.DonationType FROM Final.Donor D INNER JOIN Final.PersonalDetails PD ON D.DonorID = PD.UniqueID INNER JOIN Final.BloodDonation BD ON BD.DonorBloodType = D.BloodType AND BD.Date > '2020-01-01' WHERE PD.Gender = 'Female' AND BD.DonationType = 'Platelets' ORDER BY Date ASC, PD.LastName ASC");
            tableLabel.Text = "All Female [Platelets] Donations since 2020";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void query2Button_Click(object sender, EventArgs e)
        {
            ForQueries("SELECT DISTINCT BD.Date, Gender, PD.FirstName, PD.LastName, D.BloodType, BD.DonationType FROM Final.Donor D INNER JOIN Final.PersonalDetails PD ON D.DonorID = PD.UniqueID INNER JOIN Final.BloodDonation BD ON BD.DonorBloodType = D.BloodType AND BD.Date > '2021-01-01' WHERE BD.DonationType = 'Plasma' ORDER BY Date ASC, PD.LastName ASC");
            tableLabel.Text = "All [Plasma] Donations since 2021";
        }

        /// <summary>
        /// Donation count for all Male donors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void query3Button_Click(object sender, EventArgs e)
        {
            ForQueries("SELECT PD.FirstName, PD.LastName, D.BloodType, BD.DonationType, COUNT(*) AS DonationCount FROM Final.Donor D INNER JOIN Final.PersonalDetails PD ON D.DonorID = PD.UniqueID INNER JOIN Final.BloodDonation BD ON BD.DonorBloodType = D.BloodType AND BD.DonationType = 'Platelets' WHERE PD.Gender = 'Male' GROUP BY PD.FirstName, PD.LastName, D.BloodType, BD.DonationType ORDER BY PD.FirstName ASC");
            tableLabel.Text = "Number of [Platelet] Donations per Male";
        }
        //------------------------------------- Auxillary Methods ---------------------------------------------------------//

    }
}