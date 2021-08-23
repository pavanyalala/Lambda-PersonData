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
        public static void AverageAge(List<ContactModel> list)
        {
            if (list.Count <= 0)
                Console.WriteLine("Person details record not found ");
            else
            {
                double totalAge = 0;
                var data = list.Where(x => x.Age >= 0);
                foreach (var age in data)
                    totalAge = totalAge + age.Age;
                Console.WriteLine("Average Age " + totalAge/list.Count);
            }
        }
        public static void NameCheck(List<ContactModel> list)
        {
            if (list.Count > 0)
            {
                Console.Write("Enter Person of the Name To Check: ");
                string name = Console.ReadLine();
                var check = list.Any(x => x.Name.Equals(name));
                if (check == true)
                {
                    Console.WriteLine("Person Name Found : " + name);
                }
                else
                    Console.WriteLine("Person Name Not Found ");
            }
            else
            {
                Console.WriteLine("Person Details Record is Empty");
            }
        }
        public static void SkipRecordForAgeBelow60(List<ContactModel> list)
        {
            if (list.Count <= 0)
                Console.WriteLine(" Person Data is Empty ");

            else
            {
                list.RemoveAll(x => x.Age < 60);
                Console.WriteLine("Person Details from Record Below 60 Skipped Successfully ");
                Console.WriteLine("Details from list");
                DisplayPersonDetails(list);
            }
        }
        public void RemoveSpecificName(List<ContactModel> list)
        {
            if (list.Count <= 0)
            {
                Console.WriteLine("Person details record not found ");
            }
            else
            {
                Console.Write("Enter The Person Name To Remove : ");
                string name = Console.ReadLine();
                list.RemoveAll(x => x.Name == name);
                Console.WriteLine("Data from records removed successfully");
                Console.WriteLine("Details from list");
                DisplayPersonDetails(list);
            }
        }
        public void DataMangement()
        {
            const int ADD_PERSON = 1;
            const int RETRIVE_TOP_TWO_AGE = 2;
            const int RETRIVE_AGE_BETWEEN_13AND18 = 3;
            const int Average_AGE = 4;
            const int NAME_CHECK = 5;
            const int SKIP_DATA = 6;
            const int DISPLAY_PERSON = 7;
            const int EXIT = 8;

            List<ContactModel> list = new List<ContactModel>();
            while (true)
            {
                Console.WriteLine("Enter 1.Add Person Details " +
                                  "\n2.Retrive Top two ages below 60 " +
                                  "\n3.Retrive Ages Between 13 and 18" + 
                                  "\n4.Average Age " +
                                  "\n5.Name Check " +
                                  "\n6.Skipped Details Below Age 60" +
                                  "\n7.Display Person Details " +
                                  "\n8.Exit "
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
                        case Average_AGE:
                            PersonDetails.AverageAge(list);
                            break;
                        case NAME_CHECK:
                            PersonDetails.NameCheck(list);
                            break;
                        case SKIP_DATA:
                            PersonDetails.SkipRecordForAgeBelow60(list);
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
