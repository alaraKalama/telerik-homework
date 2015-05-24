using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeException
{
    public class InvalidRangeException<T> : ApplicationException 
    {
        private T start;
        private T end;

        public InvalidRangeException(string msg, T start, T end)
            :base (msg)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string msg, Exception innerEx, T start, T end)
            : base(msg, innerEx)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }

        public override string Message
        {
            get
            {
                return String.Format("Invalid Range Exception. Range should be between {0} and {1}", this.start, this.end);
            }
        }
    }
}
