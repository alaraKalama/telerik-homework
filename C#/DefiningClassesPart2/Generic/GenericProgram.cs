using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class GenericProgram
    {
        static void Main()
        {
            //example with strings:
            GenericList<string> names = new GenericList<string>();
            names.Add("Pesho");
            names.Add("Misho");
            names.Add("Gosho");
            names.Add("Maria");
            names.Add("Elena");
            names.Add("Pepi");
            names.Add("Sasho");

           names.PrintList(names);

           string nameAtSecondPos = names.GetByPosition(2);
           Console.WriteLine("name at second index is {0}", nameAtSecondPos);
           names.InsertAtIndex(2, "Elina");
           nameAtSecondPos = names.GetByPosition(2);
           names.PrintList(names);
           Console.WriteLine("name at second index is {0}", nameAtSecondPos);
           if (names.Contain("Sasho"))
           {
               Console.WriteLine("There is Sasho in this list.");
           }
           names.Clear();
           names.PrintList(names);


           //example with int:
           GenericList<int> numbers = new GenericList<int>();
           numbers.Add(2);
           numbers.Add(6);
           numbers.Add(44);
           numbers.Add(5);
           numbers.Add(9);
           numbers.Add(7);
           numbers.Add(12);
           numbers.Add(28);
           numbers.Add(78);
           numbers.Add(18);
           numbers.Add(348);
           numbers.Add(22);
           numbers.Add(90);
           numbers.Add(1);
           numbers.Add(54);
           numbers.Add(-3);

           numbers.PrintList(numbers);
           var min = numbers.Min();
           var max = numbers.Max();
           Console.WriteLine("min: {0}, max: {1}", min, max);
           Console.WriteLine();
           numbers.DeleteLast();
           numbers.RemoveAtIndex(10);
           numbers.PrintList(numbers);
           min = numbers.Min();
           max = numbers.Max();
           Console.WriteLine("min: {0}, max: {1}", min, max);

           
        }
    }
}
