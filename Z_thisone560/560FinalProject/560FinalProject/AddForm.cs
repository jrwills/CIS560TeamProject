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
             
        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(); //eh
            string gender = "";

            //error handle first
            if (firstText.Text == null
                        || lastText.Text == null
                            || emailText.Text == null
                                || dobText.Text == null
                                    || phoneText.Text == null
                                        || (genderListbox.CheckedItems.Count > 1 || genderListbox.CheckedItems.Count == 0))
            {
                MessageBox.Show("Please Enter Valid Credentials");
            }
            else
            {
                int c = genderListbox.SelectedIndex;
                
                switch(c)
                {
                    default:
                        MessageBox.Show("Please select ONE item from the listbox");
                        break;
                    case 0:
                        gender = "Male";
                        break;
                    case 1:
                        gender = "Female";
                        break;
                    case 2:
                        gender = "Other";
                        break;
                }
                mf.RetrieveGender(gender);
                xQuery();
            }
            
        }
    }
}
