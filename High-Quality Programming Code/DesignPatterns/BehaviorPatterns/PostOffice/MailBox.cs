using System;

namespace PostOfficeObserver
{
    public class MailBox : IObserver
    {
        public string Name;

        public MailBox(string name)
        {
            this.Name = name;
        }

        public void Update()
        {
            Console.WriteLine("New Mail for {0}", this.Name);
        }
    }
}
