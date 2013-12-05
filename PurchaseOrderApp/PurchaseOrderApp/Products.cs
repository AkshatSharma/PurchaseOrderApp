using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PurchaseOrderApp
{
    class Products
    {
        //declaring variables
        private string iPhone4s;
        private string newiPad;
        private string macbookPro;
        private string appleTV;
        private string iPodTouch;

        //Constructor
        public Products()
        {
            //initializing variables
            iPhone4s = "";
            newiPad = "";
            macbookPro = "";
            appleTV = "";
            iPodTouch = "";
        }

        //Property for IPhone4s
        public string IPhone4s
        {
            get { return iPhone4s; }
            set { iPhone4s = value; }
        }

        //Property for NewIpad
        public string NewIpad
        {
            get { return newiPad; }
            set { newiPad = value; }
        }

        //Property for MacbookPro
        public string MacbookPro
        {
            get { return macbookPro; }
            set { macbookPro = value; }
        }

        //Property for AppleTV
        public string AppleTV
        {
            get { return appleTV; }
            set { appleTV = value; }
        }

        //Property for IpodTouch
        public string IpodTouch
        {
            get { return iPodTouch; }
            set { iPodTouch = value; }
        }

    }
}
