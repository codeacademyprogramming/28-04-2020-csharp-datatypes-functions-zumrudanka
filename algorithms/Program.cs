using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            //Count digits of the number

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool condition = true;
            int counter = 0;

            while (condition)
            {
                int remainder = num % 10;
                num = (num - remainder) / 10;
                counter++;
                if (num == 0)
                    condition = false;
            }
            Console.Write(counter);
            Console.ReadLine();



            //Check prime number

            Console.WriteLine("Enter the number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < Number / 2; i++)
            {
                if (Number % 2 == 0)
                {
                    Console.WriteLine("This number is not prime");
                    break;
                }
                else
                {
                    Console.WriteLine("This number is prime");
                    break;
                }
            }


            //Check seasons

            Console.WriteLine("Enter the month number: ");
            int MonthNumber = Convert.ToInt32(Console.ReadLine());



            
                if(MonthNumber == 1 || MonthNumber == 2 || MonthNumber == 12)
                {
                 Console.WriteLine("It is winter now");
                }
                else if (MonthNumber == 3 || MonthNumber == 4 || MonthNumber == 5)
                {
                    Console.WriteLine("It is spring now");
                }
                else if (MonthNumber == 6 || MonthNumber == 7 || MonthNumber == 8)
                {
                    Console.WriteLine("It is summer now");
                }
                else if (MonthNumber == 6 || MonthNumber == 7 || MonthNumber == 8)
                {
                Console.WriteLine("It is fall now");
                }
            else
            {
                Console.WriteLine("Please, enter valid month number");
            }
        }
    }
}
