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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Functionalities for the login button
        private void loginButton_Click(object sender, EventArgs e)
        {
            //connection string to the database
            string myDatabaseConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\myDatabase.mdf;Integrated Security=True;User Instance=True";
            SqlConnection connect = new SqlConnection(myDatabaseConnection);

            //establishing the connection
            try
            {
                connect.Open();
            }
            //throws error if the database is not connected
            catch (Exception)
            {
                MessageBox.Show("Unable to connect to the desired database");
            }

            string username = userNameBox.Text;
            string password = passwordBox.Text;

            //Query for selecting everything and validating from the database
            SqlCommand command = new SqlCommand("SELECT * FROM [Login]", connect); //WHERE Username ='" + username + "' AND Password = '" + password + "'", connect);
            SqlDataReader reader = null;
            
            reader = command.ExecuteReader();

            //loop through the database
            while (reader.Read())
            {
                //if the username and password exist in the table, then login successful
                if (username == (reader["Username"].ToString()) && password == (reader["Password"].ToString()))
                {
                    label3.Text = "";
                    MessageBox.Show("You are now logged in", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WelcomeForm welcome = new WelcomeForm();
                    purchaseForm pf = new purchaseForm();
                    welcome.username = username;
                    welcome.Show();
                    this.Hide();
                }
                
                else if (username != (reader["Username"].ToString()) || password != (reader["Password"].ToString()))
                {
                    //label to show a wrong username or password
                    label3.Text = "You have entered a wrong username or password!";
                }
            }
            //Closes the database connection
            connect.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sets the password character
            passwordBox.PasswordChar = '●';
        }

        //functionalities for the sign up button
        private void button1_Click(object sender, EventArgs e)
        {
            //object of the SignUp form
            SignUp sign = new SignUp();

            //shows SingUp form
            sign.Show();

            //Hides this form
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exits the application
            Environment.Exit(0);
        }
    }
}
