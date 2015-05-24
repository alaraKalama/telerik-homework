namespace Generic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GenericList<T> where T : IComparable
    {
        //fields:
        private T[] elements;
        private int index;
        private int count;


        //the constructor:
        public GenericList()
        {
            this.elements = new T[16];
            this.index = 0;
            this.count = -1;
        }

        //methods:
        public void Add(T element)
        {
            this.elements[this.index] = element;
            this.index++;
            this.count++;

            if (this.index == this.elements.Length)
            {
                AutoGrow();
            }
        }

        public void DeleteLast()
        {
            this.elements[this.index] = default(T);
            this.index--;
            this.count--;

            if (this.index < 0)
            {
                throw new ArgumentOutOfRangeException("The list is already empty!");
            }
        }

        private void AutoGrow()
        {
            int doubledSize = 0;
            if (this.elements.Length == 0)
            {
                doubledSize = 2;
            }
            else
            {
                doubledSize = this.elements.Length * 2;
            }

            T[] newElements = new T[doubledSize];

            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = elements[i];
            }

            this.elements = newElements;
        }

        public void PrintList (GenericList<T> elements)
        {
            StringBuilder buildList = new StringBuilder();

            for (int i = 0; i <= this.count; i++)
            {
                buildList.Append(this.elements[i] + "\n");
            }

            Console.WriteLine(buildList.ToString());
        }

        public T GetByPosition(int index)
        {
            if(index < 0 || index > elements.Length)
            {
                throw new IndexOutOfRangeException("There is no such position in this list");
            }

            T element = elements[index];
            return element;
        }
        
        public void InsertAtIndex(int index, T value)
        {
            if (index < 0)
            {
                throw new ArgumentNullException("Index must be more than zero!");
            }

            if (index > this.elements.Length)
            {
                AutoGrow();
            }
            for (int i = count + 1; i > index; i--)
            {
                if (i > this.elements.Length)
                {
                    AutoGrow();
                }
                elements[i] = elements[i - 1];
               
            }
            elements[index] = value;
            this.count++;
        }

        public void RemoveAtIndex(int index)
        {
            for (int i = index; i < this.count; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[this.count] = default(T);
            this.count--;

        }

        public T Min()
        {
            T min = this.elements[0];
            for (int i = 1; i <= this.count; i++)
            {
                if (min.CompareTo(elements[i]) > 0)
                {
                    min = elements[i];
                }
            }

            return min;
              
        }

        public T Max()
        {
            T max = this.elements[0];
            for (int i = 1; i <= this.count; i++)
            {
                if (max.CompareTo(elements[i]) < 0)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        public void Clear()
        {
            for (int i = 0; i <= this.count; i++)
            {
                this.elements[i] = default(T);
            }
            this.count = -1;
        }

        public bool Contain(T value)
        {
            bool contains = false;
            for (int i = 0; i <= this.count; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

    }
}
