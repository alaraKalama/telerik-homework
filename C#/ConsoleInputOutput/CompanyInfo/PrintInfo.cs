//A company has name, address, phone number, fax number, web site and manager.
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
/*Example input:

program	user
Company name:	    Telerik Academy
Company address:	31 Al. Malinov, Sofia
Phone number:     	+359 888 55 55 555
Fax number:     	2
Web site:	        http://telerikacademy.com/
Manager first name:	Nikolay
Manager last name:	Kostov
Manager age:	    25
Manager phone:   	+359 2 981 981*/

using System;

namespace CompanyInfo
{
    class PrintInfo
    {
        static void Main()
        {
            Console.WriteLine("Please enter company data:");
            Console.Write("Company name:");
            string coName = Convert.ToString(Console.ReadLine());
            Console.Write("Company adress:");
            string coAdress = Convert.ToString(Console.ReadLine());
            Console.Write("Phone number:");
            string phoneNumber = Convert.ToString(Console.ReadLine());
            Console.Write("Fax number:");
            string fax = Convert.ToString(Console.ReadLine());
            Console.Write("Web site:");
            string webSite = Convert.ToString(Console.ReadLine());
            Console.Write("Manager\n First name:");
            string mFirstName = Convert.ToString(Console.ReadLine());
            Console.Write("Last name:");
            string mLastName = Convert.ToString(Console.ReadLine());
            Console.Write("Manager age:");
            string mAge = Convert.ToString(Console.ReadLine());
            Console.Write("Contact manager:");
            string mMobile = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\n\n\n{0}\n Adress: {1}nTel.{2}\nFax:{3}\nWeb site:{4}\nManager:{5} {6}(age:{7} tel.{8}", coName, coAdress, phoneNumber, fax, webSite, mFirstName, mLastName, mAge, mMobile);  
        }
    }
}
