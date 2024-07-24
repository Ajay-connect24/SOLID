using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_responsibility
{
    internal class Customer
    {
        public void Add()
        {
            try
            {

            }
            catch (Exception e)
            {
                //File.WriteAllText(@E:\Log.txt ,e.ToString());

                // this should not be done here
                //delegate it to some other class

                ErrorHandler errorHandler = new ErrorHandler();
                //we should not create object here its also a violation
                errorHandler.HandleError(e.ToString());

                //tightly coupled ...bad


            }
        }
    }
}
