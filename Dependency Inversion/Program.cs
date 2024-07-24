namespace Dependency_Inversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IErrorHandler errorHandler = new DbErrorHandler();
            Customer customer = new Customer(errorHandler);

            customer.Add();

        }
    }
}


