using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDataManagement
{
    class PersonDetails
    {
        public static void AddPersonDetails(List<ContactModel> list)
        {
            ContactModel contactModel = new ContactModel();
            Console.Write("Enter Serial Numer : ");
            contactModel.SSN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name of the Person : ");
            contactModel.Name = Console.ReadLine();
            Console.Write("Enter Address : ");
            contactModel.Address = Console.ReadLine();
            Console.Write("Enter age of the Person : ");
            contactModel.Age = Convert.ToInt32(Console.ReadLine());
            list.Add(contactModel);
            Console.WriteLine(" Person Added Successfully ");

        }
        public static void DisplayPersonDetails(List<ContactModel> list)
        {
            if(list.Count<=0)
                Console.WriteLine("Person details record not found ");
            else
            {
                foreach(ContactModel data in list)
                {
                    Console.WriteLine("SSN : " + data.SSN);
                    Console.WriteLine("Name : " + data.Name);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("Age : " + data.Age);
                }
            }
        }
        public void DataMangement()
        {
            const int ADD_PERSON = 1;
            const int DISPLAY_PERSON = 2;
            const int EXIT = 3;
            List<ContactModel> list = new List<ContactModel>();
            while (true)
            {
                Console.WriteLine("Enter 1.Add Person Details " +
                                  "Enter\n2.Display Person Details " +
                                  "Enter\n3.Exit "
                              );
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == EXIT)
                    break;
                {
                    switch (choice)
                    {
                        case ADD_PERSON:
                            PersonDetails.AddPersonDetails(list);
                            break;
                        case DISPLAY_PERSON:
                            PersonDetails.DisplayPersonDetails(list);
                            break;
                        default:
                            Console.WriteLine("Entered Wrong choice ");
                            break;
                    }
                    Console.WriteLine("Enter Choice");
                }
            }
            
        }
    }
}
