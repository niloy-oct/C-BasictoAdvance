using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace uWuCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niloy!");
            string name = "Niloy";
            int age = 26;
            //const  int entry = 15;
            //entry = 20;// compile error
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);
            //bool isCSharpFun = true;
            //bool isFishTasty = false;
            //Console.WriteLine(isCSharpFun);   // Outputs True
            //Console.WriteLine(isFishTasty);   // Outputs False
            Console.WriteLine("You are : " + name + Environment.NewLine + "your age : " + age);
            Console.Read();

            string userName = Console.ReadLine();
            string userOccupation = Console.ReadLine();
            string userCompanyName = Console.ReadLine();
            Console.WriteLine("You are : " + userName + Environment.NewLine + "you are : " + userOccupation + Environment.NewLine + "you worked at : " + userCompanyName);
            int firstInput = Convert.ToInt32(Console.ReadLine());
            int secondInput = Convert.ToInt32(Console.ReadLine());
            var result = Math.Max(firstInput, secondInput);
            Console.WriteLine("Bigger is : " + result);
          
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);
            int value = 10;
            Console.WriteLine(method(value));
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
            Employee objEmployee = new Employee();
            Console.WriteLine(objEmployee.name);
            Console.Read();
        }

        static int method(int value)
        {

            return 6 + value;
        }
        // method overloading
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        public class Employee
        {
           public string name = "Niloy";
        }


    }
}
