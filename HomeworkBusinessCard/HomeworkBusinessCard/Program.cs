using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HomeworkBusinessCard
{
    struct DataForBusineesCard
    {
        public string name, surname, email;
        public long phoneNumber;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            DataForBusineesCard data;

            Console.WriteLine("Give me the name: ");
            data.name = Console.ReadLine();

            Console.WriteLine("Give me the surname: ");
            data.surname = Console.ReadLine();

            Console.WriteLine("Give me the email: ");
            data.email = Console.ReadLine();

            Console.WriteLine("Give me the phone number: ");
            data.phoneNumber = Convert.ToInt64(Console.ReadLine());

            string fullName = (data.name.Length + data.surname.Length) % 2 == 0 ? $"{data.name + "  " + data.surname}" : $"{data.name + " " + data.surname}";
            string emailAdress = ($"e-mail: {data.email}".Length % 2 == 0 ? $"e-mail: {data.email}" : $"e-mail:  {data.email}");
            string telNumber = ($"phone number: {data.phoneNumber}".Length) % 2 == 0 ? $"phone number: {data.phoneNumber}" : $"phone number:  {data.phoneNumber}";
            string[] array = { fullName, emailAdress, telNumber };

            string longest = array.OrderByDescending(s => s.Length).First();
            
            string stars = string.Concat(Enumerable.Repeat("*", longest.Length + 4));
            
            Console.WriteLine(stars);
            
            foreach(string item in array)
            {
                string empty = string.Concat(Enumerable.Repeat(" ",((longest.Length + 4) - (item.Length + 2)) / 2));
                Console.WriteLine($"*{empty}{item}{empty}*");
            }
           
            Console.WriteLine(stars);
            
            Console.ReadKey();
        }
    }
}
