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
    public partial class infoAndDeliveryForm : Form
    {
        public infoAndDeliveryForm()
        {
            InitializeComponent();
        } 
        
        //declaring fields
        public int iPhone4s;
        public int iPad;
        public int macBookPro;
        public int TVapple;
        public int iPodTouch;

        public decimal total_Weight;
        public decimal weight_iPhone;
        public decimal weight_iPad;
        public decimal weight_Mac;
        public decimal weight_TV;
        public decimal weight_iPod;

        public int totalQuantity;

        public decimal iPhoneCost;
        public decimal iPadCost;
        public decimal macPro;
        public decimal appleTV;
        public decimal iPod;

        public decimal productCost;
        public decimal totalCost;

        /*public bool isChecked;
        public bool isChecked_iPad;
        public bool isChecked_mac;
        public bool isChecked_tv;
        public bool isChecked_iPod;
         */

        //functionalities for resetButton
        private void resetButton_Click(object sender, EventArgs e)
        {
            //Clears the following textboxes
            nameTextBox.Clear();
            addressTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sender textboxes are cleared
            nameTextBox.Clear();
            addressTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipTextBox.Clear();

            //Recipient textboxes are cleared
            rNameTextBox.Clear();
            rAddressTextBox.Clear();
            rCityTextBox.Clear();
            rStateTextBox.Clear();
            rZipTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Recipient textboxes are cleared
            rNameTextBox.Clear();
            rAddressTextBox.Clear();
            rCityTextBox.Clear();
            rStateTextBox.Clear();
            rZipTextBox.Clear();
        }


        private void purchaseButton_Click(object sender, EventArgs e)
        {
            //Creating objects of forms
            finalForm final = new finalForm();
            purchaseForm purchase = new purchaseForm();
            Products prod = new Products();

            //Checks if any textbox for the sender's details is left empty and reports it
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrEmpty(cityTextBox.Text)
                || string.IsNullOrEmpty(stateTextBox.Text) || string.IsNullOrEmpty(zipTextBox.Text))
            {
                MessageBox.Show("Please enter the complete details of the sender. Thank you", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Checks if any textbox for the recipient's details is left empty and reports it
            else if (string.IsNullOrEmpty(rNameTextBox.Text) || string.IsNullOrEmpty(rAddressTextBox.Text) || string.IsNullOrEmpty(rCityTextBox.Text)
                || string.IsNullOrEmpty(rStateTextBox.Text) || string.IsNullOrEmpty(rZipTextBox.Text))
            {
                MessageBox.Show("Please enter the complete details of the recipient. Thank You", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //checks if the zip code is less than 5 digits
            else if (zipTextBox.Text.Count() < 5 || rZipTextBox.Text.Count() < 5)
            {
                MessageBox.Show("Please enter a correct 5-digit zip code", "Wrong Zip", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Executes the code if no errors are reported
            else
            {
                //Calculates the total quantity of the products and stores it in the totalQuantity variable
                totalQuantity = (iPhone4s + iPad + macBookPro + TVapple + iPodTouch);

                //Calculates the total cost of all the products
                productCost = (iPhoneCost + iPadCost + macPro + appleTV + iPod);

                //checks if the overnightButton is checked
                if (overnightButton.Checked)
                {
                    //object of the OvernightPackage class
                    OvernightPackage night = new OvernightPackage();

                    //Assigning information to the fields inherited to the OvernightPackage class
                    //from the Package class
                    night.SenderName = nameTextBox.Text;
                    night.SenderAddress = addressTextBox.Text;
                    night.SenderCity = cityTextBox.Text;
                    night.SenderState = stateTextBox.Text;
                    night.SenderZIP = zipTextBox.Text;

                    night.RecipientName = rNameTextBox.Text;
                    night.RecipientAddress = rAddressTextBox.Text;
                    night.RecipientCity = rCityTextBox.Text;
                    night.RecipientState = rStateTextBox.Text;
                    night.RecipientZIP = rZipTextBox.Text;
                    night.Weight = total_Weight;



                    final.TotalWOCharge.Text = "Total Product Charges without tax: " + productCost.ToString("C");

                    final.DeliveryOptionLabel.Text = "Chosen Delivery option: Overnight Delivery";


                    final.totalWeightLabel.Text = "Total Weight: " + night.Weight.ToString("n1");
                    final.totalQuantityLabel.Text = "Total Quantity: " + totalQuantity;
                    decimal costCalculation = night.CalculateCost();
                    totalCost = costCalculation + productCost;
                    final.DeliveryCostLabel.Text = "Delivery Cost: " + costCalculation.ToString("C");
                    final.TotalCostLabel.Text = "Total Cost: " + totalCost.ToString("C");

                    final.rNameLabel.Text = night.RecipientName;
                    final.rAddressLabel.Text = night.RecipientAddress;
                    final.rCityLabel.Text = night.RecipientCity;
                    final.rStateLabel.Text = night.RecipientState;
                    final.rZipLabel.Text = night.RecipientZIP;

                    final.sNameLabel.Text = night.SenderName;
                    final.sAddressLabel.Text = night.SenderAddress;
                    final.sCityLabel.Text = night.SenderCity;
                    final.sStateLabel.Text = night.SenderState;
                    final.sZipLabel.Text = night.SenderZIP;

                    final.Show();

                    this.Close();
                }

                //Checks if the twoDayButton is checked
                else if (twoDayButton.Checked)
                {
                    //creating an object of the twoDayPackage class
                    TwoDayPackage twoDay = new TwoDayPackage();

                    //Assigning information to the fields inherited to the TwoDayPackage class
                    //from the Package class
                    twoDay.SenderName = nameTextBox.Text;
                    twoDay.SenderAddress = addressTextBox.Text;
                    twoDay.SenderCity = cityTextBox.Text;
                    twoDay.SenderState = stateTextBox.Text;
                    twoDay.SenderZIP = zipTextBox.Text;

                    twoDay.RecipientName = rNameTextBox.Text;
                    twoDay.RecipientAddress = rAddressTextBox.Text;
                    twoDay.RecipientCity = rCityTextBox.Text;
                    twoDay.RecipientState = rStateTextBox.Text;
                    twoDay.RecipientZIP = rZipTextBox.Text;
                    twoDay.Weight = total_Weight;

                    final.TotalWOCharge.Text = "Total Product Charges without tax: " + productCost.ToString("C");

                    final.DeliveryOptionLabel.Text = "Chosen Delivery option: Two-Day Delivery";

                    final.totalWeightLabel.Text = "Total Weight: " + twoDay.Weight.ToString("n1");
                    final.totalQuantityLabel.Text = "Total Quantity: " + totalQuantity;

                    decimal calculateCost = twoDay.CalculateCost();
                    totalCost = calculateCost + productCost;

                    final.DeliveryCostLabel.Text = "Delivery Cost: " + calculateCost.ToString("C");
                    final.TotalCostLabel.Text = "Total Cost: " + totalCost.ToString("C");

                    final.rNameLabel.Text = twoDay.RecipientName;
                    final.rAddressLabel.Text = twoDay.RecipientAddress;
                    final.rCityLabel.Text = twoDay.RecipientCity;
                    final.rStateLabel.Text = twoDay.RecipientState;
                    final.rZipLabel.Text = twoDay.RecipientZIP;

                    final.sNameLabel.Text = twoDay.SenderName;
                    final.sAddressLabel.Text = twoDay.SenderAddress;
                    final.sCityLabel.Text = twoDay.SenderCity;
                    final.sStateLabel.Text = twoDay.SenderState;
                    final.sZipLabel.Text = twoDay.SenderZIP;

                    final.Show();
                    this.Close();
                }
                else if (!(overnightButton.Checked && twoDayButton.Checked))
                {
                    MessageBox.Show("Please select a delivery option", "Delivery Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            purchaseForm purchase = new purchaseForm();
            this.Close();
            purchase.Show();
        }

        //Checks if the zipcode is an integer
        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                Convert.ToInt32(zipTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Zip Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             */
        }

        //Checks if the zipcode is an integer
        private void rZipTextBox_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                Convert.ToInt32(rZipTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Zip Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             */
        }

        private void rZipTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void zipTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(rNameTextBox.Text) || string.IsNullOrEmpty(rAddressTextBox.Text) || string.IsNullOrEmpty(rCityTextBox.Text)
                || string.IsNullOrEmpty(rStateTextBox.Text) || string.IsNullOrEmpty(rZipTextBox.Text)))
            {
                rNameTextBox.Text = nameTextBox.Text;
                rAddressTextBox.Text = addressTextBox.Text;
                rStateTextBox.Text = stateTextBox.Text;
                rCityTextBox.Text = cityTextBox.Text;
                rZipTextBox.Text = zipTextBox.Text;
            }
            else if ((string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrEmpty(cityTextBox.Text)
                || string.IsNullOrEmpty(stateTextBox.Text) || string.IsNullOrEmpty(zipTextBox.Text)))
            {
                nameTextBox.Text = rNameTextBox.Text;
                addressTextBox.Text = rAddressTextBox.Text;
                cityTextBox.Text = rCityTextBox.Text;
                stateTextBox.Text = rStateTextBox.Text;
                zipTextBox.Text = rZipTextBox.Text;
            }
        }

        private void infoAndDeliveryForm_Load(object sender, EventArgs e)
        {
            label17.Text = "Total Weight:" + "\n" + "  " + total_Weight.ToString("n") + " Oz";
        }
    }
}
