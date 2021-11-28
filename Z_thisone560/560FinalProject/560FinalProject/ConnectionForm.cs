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
            //InitialQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";

            SqlConnection connect = new SqlConnection(connectionString);

            try
            {
                connect.Open();
                MessageBox.Show("You are connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Could not connect");
                connect.Close();
            }
        }

        /*private void InitialQuery()
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
                        //DataTable myTable = new DataTable();
                        //myTable.Load(myReader);
                        //dataForm.Rows = myTable.Rows;
                        //myConnection.Close();

                    }
                }
            }
        }*/
    }
}
