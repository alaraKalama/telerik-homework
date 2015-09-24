using System;
using System.Collections.Generic;

namespace PostOfficeObserver
{
    public class PostOffice : IPostOffice
    {
        private string Address;
        private List<IObserver> mailBoxes;

        public PostOffice(string address)
        {
            this.Address = address;
            mailBoxes = new List<IObserver>();
        }

        public void addMailBox(IObserver mailBox)
        {
            this.mailBoxes.Add(mailBox);
        }

        public void notifyMailBox()
        {
            foreach(var mailBox in this.mailBoxes)
            {
                mailBox.Update();
            }
        }

        public void removeMailBox(IObserver mailBox)
        {
            this.mailBoxes.Remove(mailBox);
        }
    }
}
