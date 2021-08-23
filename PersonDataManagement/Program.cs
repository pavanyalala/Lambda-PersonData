using System;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data management program");
            PersonDetails personDetails = new PersonDetails();
            personDetails.DataMangement();
        }
    }
}
