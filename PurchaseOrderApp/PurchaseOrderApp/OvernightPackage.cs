using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PurchaseOrderApp
{
    //inherits properties of the Package class and then 
    //adds its own functionalities
    class OvernightPackage : Package
    {

        private decimal overnightFeePerOunce;

        public OvernightPackage()
        {
            OvernightFeePerOunce = 0.39M;
        }

        public decimal OvernightFeePerOunce
        {
            get { return overnightFeePerOunce; }
            set { overnightFeePerOunce = value; }
        }

        // calculate shipping cost for package
        public override decimal CalculateCost()
        {
            return Weight * (CostPerOunce + OvernightFeePerOunce);
        } // end method CalculateCost

    }
}
