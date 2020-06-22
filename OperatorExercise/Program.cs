using System;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lets divide two numbers");
            Console.WriteLine("1st number");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2nd number");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the radius of your circle");
            var num3 = double.Parse(Console.ReadLine());
            
            var quotient = DivideMethod(num1, num2);
            var remainder = RemainderMethod(num1, num2);
            var area = AreaMethod(num3);

            Console.WriteLine($"{num1}/{num2} is {quotient} remainder {remainder}");
            Console.WriteLine("What is the radius of your circle");
            Console.WriteLine($"{num3}");
            Console.WriteLine($"The area of a circle with radius of {num3} is {area}");


        }
        public static int AddMethod(int num1, int num2)
        {

            return num1+num2;
        }
        public static int SubtractMethod(int num1, int num2)
        {

            return num1 - num2;
        }
        public static int MultiplyMethod(int num1, int num2)
        {

            return num1 * num2;
        }
        public static int DivideMethod(int num1, int num2)
        {

            return num1 / num2;
        }
        /*public static int QuotientMethod(int num1)
        {
            int a1 = 0;
            int a2 = 0;
            return num1 = DivideMethod(a1,a2);
        }*/
        public static int RemainderMethod(int num1, int num2)
        {

            return num1 % num2;
        }
        public static double AreaMethod(double num2)
        {
            
            
            return Math.PI * (num2*num2);
        }

    }
}
