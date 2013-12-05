using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PurchaseOrderApp
{
    //inherits properties from the Package class and then
    //adds its own functionalities
    class TwoDayPackage : Package
    {
        private decimal flatFee = 6.5M;

        //Property for FlatFee
        public decimal FlatFee
        {
            get { return flatFee; }
            set { flatFee = value; }
        }

        // calculate shipping cost for package
        public override decimal CalculateCost()
        {
            return base.CalculateCost() + FlatFee;
        } // end method CalculateCost

    }
}
