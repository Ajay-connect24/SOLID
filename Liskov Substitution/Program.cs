namespace Liskov_Substitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new GoldCustomer());
            customers.Add(new SilverCustomer());
            customers.Add(new EnquiryCustomer()); //causes exception

            foreach (var customer in customers)
            {
                customer.Add();
            }
        }
    }
}


//the enquiry customer cannot br added
//which throws an exception . handled by interfaces