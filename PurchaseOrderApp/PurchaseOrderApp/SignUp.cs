using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PurchaseOrderApp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        //connection string
        public SqlConnection cnct = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\myDatabase.mdf;Integrated Security=True;User Instance=True");

        //functionalities for the sign up button
        private void signupButton_Click(object sender, EventArgs e)
        {
            //Query for inserting the values into the database
            SqlCommand cm = new SqlCommand("INSERT INTO [Login] (ID, Username, Password) VALUES (@ID, @Username, @Password)", cnct);
            //adds desired username
            cm.Parameters.AddWithValue("@Username", usernameBox.Text);
            //adds desired password
            cm.Parameters.AddWithValue("@Password", passwordBox.Text);
            //adds desired ID
            cm.Parameters.AddWithValue("@ID", idTextBox.Text);
            //cm.ExecuteScalar();
            
            
           
            try
            {
                
                int affectedRows = cm.ExecuteNonQuery();
               
                //checks if the data has been inserted into the database
                if (affectedRows > 0)
                {
                    if (usernameBox.Text == "" || passwordBox.Text == "" || idTextBox.Text == "")
                    {
                        MessageBox.Show("Please Fill the complete details", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Sign Up Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userDetailLabel.Text = "Your Username: " + usernameBox.Text;
                        passDetailLabel.Text = "Your Password: " + passwordBox.Text;
                        usernameBox.Clear();
                        passwordBox.Clear();
                        idTextBox.Clear();
                        loginLabel.Text = "Please login now!";
                        cnct.Close();
                    }
                }
                //if data is not inserted, throws error
                else
                {
                    MessageBox.Show("Insert Error!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            try
            {
                cnct.Open();
            }
            catch (SqlException i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
