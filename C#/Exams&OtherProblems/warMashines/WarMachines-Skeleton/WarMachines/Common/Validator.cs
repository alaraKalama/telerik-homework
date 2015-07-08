using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WarMachines.Common;

namespace WarMachines.Common
{
    public static class Validator
    {
        public static void ValidateName(string name, string message = null)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException();
            }
        }

        public static void ValidateIfNull(object obj, string messege = null)
        {
            if(obj == null)
            {
                throw new NullReferenceException(messege);
            }
        }
        
    }
}
