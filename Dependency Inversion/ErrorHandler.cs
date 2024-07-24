using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    public interface IErrorHandler
    {
        void HandleError(string message);
    }
    internal class FileErrorHandler:IErrorHandler
    {
        public void HandleError(string message) 
        {
            File.WriteAllText(@"E:\Log1.txt", message);
        }
    }

    internal class DbErrorHandler : IErrorHandler
    {
        public void HandleError(string message)
        {
            File.WriteAllText(@"E:\Log2.txt", message);
        }
    }
}
