namespace Liskov_Substitutiion_Solved_interface

{
   


    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Customer> customers = new List<Customer>();
            List<ICustomer> customers = new List<ICustomer>();
            customers.Add(new Customer());
            customers.Add(new GoldCustomer());
            customers.Add(new SilverCustomer());
            // customers.Add(new EnquiryCustomer());

            foreach (var customer in customers)
            {
                customer.Add();
            }
        }
    }
}


