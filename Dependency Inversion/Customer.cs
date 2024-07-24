using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class Customer
    {
        private IErrorHandler errorHandler;

        public Customer(IErrorHandler errorHandler) 
        {
            this.errorHandler = errorHandler;
        }
        public void Add()
        {
            try
            {

            }
            catch (Exception e)
            {
                errorHandler.HandleError(e.ToString());
              

               

            }
        }
    }
}
