using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    
    public class Customer : ICustomer ,IRead
    {
        public int CustomerType { get; set; }
        public virtual void Add()
        {
            try
            {
                //This is the logic to add customer to database.
            }
            catch (Exception ex)
            {
                //ErrorHandler errorHandler = new ErrorHandler();
                // errorHandler.HandleError(ex.ToString());
            }
        }

        public double CalculateDiscount()
        {
            //if (CustomerType == 1)
            //{
            //    return 10;
            //}
            //else
            //{
            //    return 0;
            //}
            return 0;
        }

        public void Print()
        {
            Console.WriteLine("Printing");
        }
    }

    public class GoldCustomer : ICustomer //open for extension
    {
        public virtual double CalculateDiscount()
        {
            return 10;
        }

        public void Add()
        {

        }

        double IEnquiry.CalculateDiscount()
        {
            throw new NotImplementedException();
        }
    }

    public class SilverCustomer : ICustomer //open for extension
    {


        public double CalculateDiscount()
        {
            return 5;
        }

        //void ICustomer.Add()
        //{

        //}

        public void Add()
        {

        }

        double IEnquiry.CalculateDiscount()
        {
            throw new NotImplementedException();
        }
    }
    public class EnquiryCustomer : IEnquiry
    {
        public double CalculateDiscount()
        {
            return 2;
        }
        //public override void Add()
        //{
        //    throw new NotImplementedException();
        //}
    }


    public interface IEnquiry
    {
        public double CalculateDiscount();
    }

    public interface ICustomer : IEnquiry
    {
        public void Add();
    }

    public interface IRead :ICustomer
    {

        public void Print();
    }
}
