using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefiningClassesPart_1;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;

namespace DefiningClassesPart_1
{
    public class Test
    {

         public string Testing(GSM[] phones)
        {
            string result = string.Empty;
            StringBuilder res = new StringBuilder();
            foreach (GSM phone in phones)
            {
                res.Append(phone.DisplayInfo(phone));
            }
            result = res.ToString();
            return result;
        }
    }
}
