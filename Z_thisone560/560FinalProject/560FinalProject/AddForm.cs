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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void xQuery()
        {
            string first = firstText.Text;
            string last = lastText.Text;
            string email = emailText.Text;
            string query = "INSERT Final.PersonalDetails(FirstName, LastName, Email) VALUES (N'{first}', N'{last}', N'{email}')";

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
                            //dataForm.DataSource = dt;
                        }
                    }
                }
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (firstText.Text == null
                        || lastText.Text == null
                            || emailText.Text == null
                                || dobText.Text == null
                                    || phoneText.Text == null
                                        || (genderListbox.CheckedItems.Count > 1 || genderListbox.CheckedItems.Count == 0))
            {
                MessageBox.Show("Please Enter Valid Credentials and Check only ONE box");
            }
            else
            {

            }
        }
    }
}
