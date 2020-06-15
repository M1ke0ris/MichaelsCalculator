using System;

namespace ConsoleApplication2SimpleColculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            string sign;
            int answer;
            
            Console.WriteLine("Welcome at Misha's calculator! Please enter first number");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a sign(+ , - , * , /)");
            sign = Console.ReadLine();
            
            Console.WriteLine("Please enter second nubmer");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (sign == "*")
            {
                answer = firstNumber * secondNumber;
                Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {answer}");
            }
            else if (sign == "-")
            {
                answer = firstNumber - secondNumber;
                Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {answer}");
            }
            else if (sign == "+")
            {
                answer = firstNumber + secondNumber;
                Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {answer}");
            }
            else if (sign == "/")
            {
                answer = firstNumber / secondNumber;
                Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {answer}");
            }
        }
    }
}