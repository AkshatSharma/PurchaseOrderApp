using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PurchaseOrderApp
{
    class Package
    {
        //fields
        private decimal costPerOunce = .20M;
        private string senderName;
        private string senderAddress;
        private string senderCity;
        private string senderState;
        private string senderZIP;

        private string recipientName;
        private string recipientAddress;
        private string recipientCity;
        private string recipientState;
        private string recipientZIP;

        private decimal weight;

        //Constructor
        public Package()
        {
            senderName = "";
            senderAddress = "";
            senderCity = "";
            senderState = "";
            senderZIP = "";

            recipientName = "";
            recipientAddress = "";
            recipientCity = "";
            recipientState = "";
            recipientZIP = "";

            weight = 0;
        }

        //Property for SenderName
        public string SenderName
        {
            get { return senderName; }
            set { senderName = value; }
        }

        //Property for SenderAddress
        public string SenderAddress
        {
            get { return senderAddress; }
            set { senderAddress = value; }
        }

        public string SenderCity
        {
            get { return senderCity; }
            set { senderCity = value; }
        }

        //Property for SenderState
        public string SenderState
        {
            get { return senderState; }
            set { senderState = value; }
        }

        //Property for SenderZIP
        public string SenderZIP
        {
            get { return senderZIP; }
            set { senderZIP = value; }
        }

        //Property for RecipientName
        public string RecipientName
        {
            get { return recipientName; }
            set { recipientName = value; }
        }

        //Property for RecipientAddress
        public string RecipientAddress
        {
            get { return recipientAddress; }
            set { recipientAddress = value; }
        }

        //Property for RecipientCity
        public string RecipientCity
        {
            get { return recipientCity; }
            set { recipientCity = value; }
        }

        //Property for RecipientState
        public string RecipientState
        {
            get { return recipientState; }
            set { recipientState = value; }
        }

        //Property for RecipientZIP
        public string RecipientZIP
        {
            get { return recipientZIP; }
            set { recipientZIP = value; }
        }

        //Property for Weight
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //Property for CostPerOunce
        public decimal CostPerOunce
        {
            get { return costPerOunce;}
            set { costPerOunce = value; }
        }

        //CalculateCost method
        public virtual decimal CalculateCost()
        {
            return Weight * CostPerOunce;
        } // end method CalculateCost

    }
}
