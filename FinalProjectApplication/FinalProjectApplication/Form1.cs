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
                        //DataTable myTable = new DataTable();
                        //myTable.Load(myReader);
                        //dataForm.Rows = myTable.Rows;
                        //myConnection.Close();

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Final.PersonalDetails";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB.TestDatabase2;Integrated Security=True";
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
                        //DataTable myTable = new DataTable();
                        //myTable.Load(myReader);
                        //dataForm.Rows = myTable.Rows;
                        //myConnection.Close();

                    }
                }
            }
        



            /*try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                label1.Text = "i am connected";
                DataSet ds = new DataSet();
                string test = ds.DataSetName;
                int count = dataGridView1.Rows.Count;
                MessageBox.Show("hi");
                label2.Text = count.ToString();
                connect.Close();//me
            }
            catch (Exception ex)
            {
                label1.Text = "ERROR did not connect";
                connect.Close();
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
