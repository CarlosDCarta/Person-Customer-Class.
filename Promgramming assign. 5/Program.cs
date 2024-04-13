using System;
using System.Security.Cryptography.X509Certificates;
using Promgramming_assign._5;

namespace MyApp
{
    class Program
    {
       static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person person1 = new Person("carlos", "D", "cartagena", "123456", "baker", "austin", "chester", "virginia", "234567", "caratgenacd@vcu.edu");
            Person person2 = new Person("carlo", "D", "cartagena", "123956", "baker", "austin", "chester", "virginia", "235567", "caratgenacd@vcu.edu");
            Person person3 = new Person("carl", "D", "cartagena", "323456", "lol", "austin", "chester", "virginia", "234567", "caratgenacd@vcu.edu");
            Person person4 = new Person("car", "D", "cartagena", "623456", "bake", "austin", "chester", "virginia", "232567", "caratgenacd@vcu.edu");
            Person person5 = new Person("los", "D", "cartagena", "12456", "jake", "austin", "chester", "virginia", "234517", "caratgenacd@vcu.edu");
            Person person6 = new Person("dan", "D", "cartagena", "1256", "WHite", "austin", "chester", "virginia", "334567", "caratgenacd@vcu.edu");

            //adding people to list
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);
            people.Add(person1);

            foreach (Person person in people)
            {
                person.ShippingLabel();
            }
      
            List<Customer> people2 = new List<Customer>();
            Customer person7 = new Customer(new DateTime(2015, 8, 6));
            Customer person8 = new Customer(new DateTime(2017, 9, 2));
            Customer person9 = new Customer(new DateTime(2009, 11, 7));
            Customer person10 = new Customer(new DateTime(2020, 1, 2));
            
            //adding customers
            people2.Add(person7);
            people2.Add(person8);
            people2.Add(person9);
            people2.Add(person10);


            foreach(Customer person in people2)
            {
                int YearsAsCustomer = person.GetJoinDate();
                int[] listOfYears = { YearsAsCustomer };
                for (int i = 0; i < listOfYears.Length; i++)
                {
                    // Could not firgure out
                    Console.WriteLine(listOfYears[i]);
                }
                
                
            }
           

            
        }
        

        
    }
}
