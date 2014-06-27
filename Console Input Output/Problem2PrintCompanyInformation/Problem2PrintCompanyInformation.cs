namespace Problem2PrintCompanyInformation
{
    using System;

    public class Problem2PrintCompanyInformation
    {
        public static void Main()
        {
            // A company has name, address, phone number, fax number, web site and manager.
            // The manager has first name, last name, age and a phone number. Write a program that reads the
            // information about a company and its manager and prints it back on the console.
            Console.WriteLine("Please enter the name of the company");
            string companyName = Console.ReadLine();
            Console.WriteLine("Please enter the address of the company");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Please enter the phone number of the company");
            string companyPhoneNumber = Console.ReadLine();
            Console.WriteLine("Please enter the fax number of the company");
            string companyFaxNumber = Console.ReadLine();
            Console.WriteLine("Please enter the website of the company");
            string companyWebSite = Console.ReadLine();
            Console.WriteLine("Please enter the first name of the manager");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Please enter the last name of the manager");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Please enter the age of the manager");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the phone number of the manager");
            string managerPhoneNumber = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("The name of the company is: {0}", companyName);
            Console.WriteLine("The address of the company is: {0}", companyAddress);
            Console.WriteLine("The phone number of the company is: {0}", companyPhoneNumber);
            Console.WriteLine("The fax number of the company is: {0}", companyFaxNumber);
            Console.WriteLine("The website of the company is: {0}", companyWebSite);
            Console.WriteLine("The first name of the manager is: {0}", managerFirstName);
            Console.WriteLine("The last name of the manager is: {0}", managerLastName);
            Console.WriteLine("The age of the manager is: {0}", managerAge);
            Console.WriteLine("The phone number of the manager is: {0}", managerPhoneNumber);
        }
    }
}