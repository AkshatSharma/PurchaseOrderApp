using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PurchaseOrderApp
{
    public partial class WelcomeForm : Form
    {
        public string username;

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Object of the form
            productVideos video = new productVideos();

            //Displays the productVideos form
            video.Show();
        }

        //functionalities for the continue shopping button
        private void button1_Click(object sender, EventArgs e)
        {
            //Objects of the forms
            Form1 fm = new Form1();
            purchaseForm pf = new purchaseForm();

            //Text for the label on purchaseForm
            pf.label11.Text = "You are logged in as: " + "\n" + "    " + username;

            //Displays the purchaseForm
            pf.Show();

            //Closes this form
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Exits the application
            Environment.Exit(0);
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            //Text for greetingLabel
            greetingLabel.Text = "Welcome, " + "\n" + username;
        }
    }
}
