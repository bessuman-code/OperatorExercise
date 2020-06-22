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



            //Thought Exercise

            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine($"{num1}/{num2} is {quotient} remainder {remainder}");
            Console.WriteLine("What is the radius of your circle");
            Console.WriteLine($"{num3}");
            Console.WriteLine($"The area of a circle with radius of {num3} is {area}");
            Console.WriteLine(k);

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var helpGuess = 1 + favNumber;
            Console.WriteLine($"Guess a number b/n from 1 to 1000");
            Console.WriteLine($"Let me help you, it is 1 + that number {helpGuess}");
            var userInput = int.Parse(Console.ReadLine());
            

            if (userInput == favNumber)
            {
                Console.WriteLine($"Success {favNumber}");


            } 
            else
            {
                Console.WriteLine($"Wrong {favNumber}");
            }
            


            
            

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
