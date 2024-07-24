namespace SOLID_PRINCIPLES
{
    /*
    * S - Single Responsibility Principle -> one class must always have single type responsiblity
    * O - Open Closed Principle ->  Open for extension - close the modification -> we use classes to solve this issue based on customers
    * L - Liskov Substitution Principle -> If we inherit the parent class and override it's method there should not be any inturruption or break for this method. so we use Interfaces to solve this issue
    * I - Interface Segregation Principle
    * D - Dependency Inversion Principle
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
