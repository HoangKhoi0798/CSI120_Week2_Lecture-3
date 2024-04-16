using System;

namespace CSI120_Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hoang Khoi Gia Nguyen

            // 6 Fundamentals
            // Inputs
            // Outputs
            // Loops
            // Conditions
            // Variables
            // Operations


            Integer();
            Console.WriteLine();
            CharacterExample();
            Console.WriteLine();
            Operation1();
            Console.WriteLine();
        }

        static void CharacterExample()
        {
            string word = "Hello";

            char letter = 'H';
            char lowerCaseH = (char)((int)letter + 32);

            Console.WriteLine(lowerCaseH);
            Console.WriteLine((char)('a' + ' '));
        }

        static void Integer()
        {
            int age = 40;
            int daysInYear = 365;
            int daysAlive = age * daysInYear;

            Console.WriteLine($"You have been alive for {daysAlive} days");

        }

        static void Operation1()
        {
            Console.WriteLine("Lecture 3 Notes");
            Console.WriteLine();

            int a1a = 5;
            int a1b = 3;
            int a1c = 10;
            int a1d = 4;
            int a1e = 6;
            int a1f = 2;
            int a1g = 12;
            int a1h = 7;
            int a1i = 20;
            int a1j = 9;

            int q1a = a1a + a1b;
            int q2a = a1c - a1d;
            int q3a = a1e * a1f;
            int q4a = a1g + a1h;
            int q5a = a1i - a1j;
            int q6a = a1d * a1a;

            Console.WriteLine($"1. 5 + 3 = {q1a}");
            Console.WriteLine($"2. 10 - 4 = {q2a}");
            Console.WriteLine($"3. 6 * 2 = {q3a}");
            Console.WriteLine($"4. 12 + 7 = {q4a}");
            Console.WriteLine($"5. 20 - 9 = {q5a}");
            Console.WriteLine($"6. 4 * 5 = {q6a}");
            Console.WriteLine();

            Console.WriteLine("Parsing");
            Console.WriteLine();

            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            int userNum = int.Parse(userInput);

            int div10 = 10;
            int baseSum = 0;
            Console.WriteLine($"Input value: {userNum}");
            Console.WriteLine($"Base Value: {baseSum}");
            Console.WriteLine();

            int singleValue = userNum % div10;
            baseSum += singleValue;
            userNum /= div10;
            Console.WriteLine($"Current value: {userNum}");
            Console.WriteLine($"Value for operation: {baseSum}");

            singleValue = userNum % div10;
            baseSum += singleValue;
            userNum /= div10;
            Console.WriteLine($"Current value: {userNum}");
            Console.WriteLine($"Value for operation: {baseSum}");

            singleValue = userNum % div10;
            baseSum += singleValue;
            userNum /= div10;
            Console.WriteLine($"Current value: {userNum}");
            Console.WriteLine($"Value for operation: {baseSum}");

            //Can an Integral hold a whole number?
            //Yes, the Integral type are variables that hold whole numbers.
            //What happens when you try to assign one? 
            //A value is assigned, as long as it is within the range of the type.
            
            //Why and when do we "parse" a value(convert a string type to another type like int )
            //When you need to convert the string type into another type (like int) for other purposes (like math)
            
            //What is the main difference between the different integral types?
            //They have different ranges (the amount of numbers they can hold) and some can hold negative numbers.
        }
    }
}
