﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_responsibility
{
    internal class ErrorHandler
    {
        public void HandleError(string error)
        {
            File.WriteAllText(@"Exception:\Lof.txt",error);
        }
    }
}
