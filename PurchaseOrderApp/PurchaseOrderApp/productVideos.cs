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
    public partial class productVideos : Form
    {
        public productVideos()
        {
            InitializeComponent();
        }

        //SendToBack method
        public void sendToBack()
        {
            //sends pictureBox2 back
            pictureBox2.SendToBack();

            //sends label1 back
            label1.SendToBack();

            //sends label2 back
            label2.SendToBack();
        }

        private void iPhone4sVid_Load(object sender, EventArgs e)
        {
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }

        //iPhone 4s video button
        private void button1_Click(object sender, EventArgs e)
        {
            //calls method
            sendToBack();

            //Navigates to the iPhone4s Video
            webBrowser1.Navigate(@"http://www.youtube.com/watch?v=f_JRZI9o49w&autoplay=1");
        }

        //
        private void iPadButton_Click(object sender, EventArgs e)
        {
            //calls method
            sendToBack();

            //Navigates to the new iPad Video
            webBrowser1.Navigate(@"http://www.youtube.com/watch?v=AEngFNb5CRU&autoplay=1");
        }

        private void macButton_Click(object sender, EventArgs e)
        {
            //calls method
            sendToBack();

            //Navigates to the MacBook Pro Video
            webBrowser1.Navigate(@"http://www.youtube.com/watch?v=5j2zyp6qcbk");
        }

        private void tvButton_Click(object sender, EventArgs e)
        {
            //calls method
            sendToBack();

            //Navigates to the Apple TV Video
            webBrowser1.Navigate(@"http://www.youtube.com/watch?v=fHTmRSTX7C8");
        }

        private void iPodButton_Click(object sender, EventArgs e)
        {
            //calls method
            sendToBack();

            //Navigates to the iPod Touch Video
            webBrowser1.Navigate(@"http://www.youtube.com/watch?v=EuBw33FBlrs");
        }
    }
}
