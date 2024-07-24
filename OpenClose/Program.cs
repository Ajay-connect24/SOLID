namespace OpenClose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new GoldCustomer());
            customers.Add(new SilverCustomer());
            customers.Add(new EnquiryCustomer());

            foreach (var customer in customers)
            {
                
                Console.WriteLine(customer.CalculateDiscount());
            }



        }
    }
}

//we added new type of customer enquiry customer without mmodifiying the exisiting class cutomer or gold customer

//open for extension, closed for 