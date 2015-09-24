namespace PostOfficeObserver
{
    using System;
    class Start
    {
        static void Main()
        {
            MailBox StefanoviMail = new MailBox("Stefanovi");
            MailBox IvanoviMail = new MailBox("Ivanovi");
            MailBox PeshoMail = new MailBox("Pesho");
            PostOffice thePost = new PostOffice("ul.Stefan Karadza");

            Console.WriteLine("Adding tree mail boxes");
            thePost.addMailBox(StefanoviMail);
            thePost.addMailBox(IvanoviMail);
            thePost.addMailBox(PeshoMail);
            thePost.notifyMailBox();
            Console.WriteLine();
            Console.WriteLine("Removing Ivanovi");
            thePost.removeMailBox(IvanoviMail);
            thePost.notifyMailBox();
            Console.Read();
        }
    }
}