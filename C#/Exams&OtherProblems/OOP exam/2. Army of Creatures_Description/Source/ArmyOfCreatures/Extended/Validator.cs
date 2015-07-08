using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended
{
    public class Validator
    {
        public static void CheckIfNull(object obj, string messege = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(messege);
            }
        }

        public static void ValidateRange(int input, int min, int max = int.MaxValue, string messege = null)
        {
            if (input < min || input > max)
            {
                throw new IndexOutOfRangeException();
            }
        }

    }
}
