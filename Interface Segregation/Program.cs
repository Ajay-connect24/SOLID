namespace Interface_Segregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////List<Customer> customers = new List<Customer>();
            //List<ICustomer> customers = new List<ICustomer>();
            //customers.Add(new Customer());
            //customers.Add(new GoldCustomer());
            //customers.Add(new SilverCustomer());
            //// customers.Add(new EnquiryCustomer());

            //foreach (var customer in customers)
            //{
            //    customer.Add();
            //}

            IRead customer = new Customer();
            customer.Print();
            //for new customer to have add and other methods
            customer.CalculateDiscount();



        }
    }
}
// a new customer came ; but he needs to implement a func to print sll customers, but if chnages the Interface ,
// then all customers need to implement that functionality

//people dont want is forced to implemet the interface

//create another inteface and nay customer implementing Iread is able to read

//we need to add normal adding functionality