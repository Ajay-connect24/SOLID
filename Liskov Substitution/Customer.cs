using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public class Customer
    {
        public int CustomerType { get; set; }

        public virtual double CalculateDiscount()
        {
            return 0;
        }

        public virtual void Add()
        {
            // Implementation for adding a customer
            Console.WriteLine("Added Customer");
        }
    }

    public class GoldCustomer : Customer
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 10;
        }
    }

    public class SilverCustomer : Customer
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
            return base.CalculateDiscount() + 2;
        }

        public override void Add() 
        {
            throw new NotImplementedException();
        }
    }

    
}

