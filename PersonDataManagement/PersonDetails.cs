using System;
using System.Collections.Generic;
using System.Linq;
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
        public static void RetriveTopTwoAgesBelow60(List<ContactModel> list)
        {
            if (list.Count <= 0)
                Console.WriteLine("Person details record not found ");
            else
            {
                var data = list.Where(x => x.Age < 60).Take(2);
                foreach(var details in data)
                {
                    Console.WriteLine("Serial Number : " + details.SSN);
                    Console.WriteLine("Name : " + details.Name);
                    Console.WriteLine("Address : " + details.Address);
                    Console.WriteLine("Age : " + details.Age);
                }
            }
        }
        public static void RetriveTopTwoAgesBetween13And18(List<ContactModel> list)
        {
            if (list.Count <= 0)
                Console.WriteLine("Person details record not found ");
            else
            {
                var data = list.Where(x => x.Age >= 13 && x.Age <= 18).Take(2);
                foreach (var details in data)
                {
                    Console.WriteLine("Serial Number : " + details.SSN);
                    Console.WriteLine("Name : " + details.Name);
                    Console.WriteLine("Address : " + details.Address);
                    Console.WriteLine("Age : " + details.Age);
                }
            }
        }
        public void DataMangement()
        {
            const int ADD_PERSON = 1;
            const int RETRIVE_TOP_TWO_AGE = 2;
            const int RETRIVE_AGE_BETWEEN_13AND18 = 3;
            const int DISPLAY_PERSON = 4;
            const int EXIT = 5;

            List<ContactModel> list = new List<ContactModel>();
            while (true)
            {
                Console.WriteLine("Enter 1.Add Person Details " +
                                  "\n2.Retrive Top two ages below 60 " +
                                  "\n3.Retrive Ages Between 13 and 18" + 
                                  "Enter\n4.Display Person Details " +
                                  "Enter\n5.Exit "
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
                        case RETRIVE_TOP_TWO_AGE:
                            PersonDetails.RetriveTopTwoAgesBelow60(list);
                            break;
                        case RETRIVE_AGE_BETWEEN_13AND18:
                            PersonDetails.RetriveTopTwoAgesBetween13And18(list);
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
