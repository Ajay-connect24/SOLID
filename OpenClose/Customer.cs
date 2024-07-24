using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public class Customer //nothing added and closed for modification
    {
        public int CustomerType { get; set; }

        //public virtual double CalculateDiscount()
        //{
        //    if (CustomerType == 0) return 0;
        //    else if (CustomerType == 1) return 1;
        //    else if (CustomerType == 2) return 2;
        //}

        //in efficient

        public virtual double CalculateDiscount()
        {
            return 0;
        }



        public virtual void Add()
        {
            // Implementation for adding a customer
        }
    }

    public class GoldCustomer : Customer //open for extension
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 10;
        }
        public virtual void Add()
        {
            // Implementation for adding a customer
        }
    }

    public class SilverCustomer : Customer //open for extension
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 5;
        }
    }

    public class EnquiryCustomer : Customer
    {
        public override double CalculateDiscount()
        {
            return 2; // Enquiry customers do not get a discount
        }

    }
}
