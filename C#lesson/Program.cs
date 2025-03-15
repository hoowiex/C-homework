using System.Numerics;

namespace C_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number1();
            Number2();
            Number3();
            Number4();
            Number5();
            Number6();
            Number7();
            Number8();
            Number9();
            Number10();
            Console.WriteLine("\n------------------\n\n\"Enter first number: ");
            int firstNum, secondNum;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out firstNum))
                {
                    break;
                }

                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("Enter second number: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out secondNum))
                {
                    break;
                }

                Console.WriteLine("Invalid input");
            }

            Console.WriteLine($"Sum:{Number11(firstNum, secondNum)}");
            Number12();
        }

        static void Number1()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    break;
                }

                Console.WriteLine("Invalid input");
            }

            Console.WriteLine($"Your name is {name}, your age is {age}.");
        }

        static void Number2()
        {
            int newInt = 15;
            double newDouble = 9.34;
            char newChar = 'H';
            string newString = "hello";

            Console.WriteLine($"\n------------------\n\nInt value: {newInt}\nDouble value: {newDouble}\nChar value: {newChar}\nString value: {newString}");
        }

        static void Number3()
        {
            Console.WriteLine("\n------------------\n\nEnter string to convert to int: ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int stringToTransform))
                {
                    Console.WriteLine($"Converted and doubled number: {stringToTransform * 2}");
                    break;
                }

                Console.WriteLine("Cannot be converted to int");
            }
        }

        static void Number4()
        {
            Console.WriteLine("\n------------------\n\nEnter a number to check:");
            int number;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }

                Console.WriteLine("Invalid input");
            }

            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
        }

        static void Number5()
        {
            Console.WriteLine("\n------------------\n\nEnter number of month: ");

            int month;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out month))
                {
                    break;
                }

                Console.WriteLine("Invalid input");
            }

            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }
        }

        static void Number6()
        {
            Console.WriteLine("\n------------------\n\n");
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Number7()
        {
            int sum = 0;
            int i = 1;

            while (i <= 50)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("\n------------------\n\n\"Sum from 1 to 50: " + sum);
        }

        static void Number8()
        {
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                array[i] = i + 1;
                Console.WriteLine("\n------------------\n\n");
                Console.WriteLine(array[i] + "/t");
            }
        }

        static void Number9()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 101);

            Console.WriteLine($"\n------------------\n\nRandom number: {randomNumber}");
        }

        static void Number10()
        {
            Random random = new Random();
            int[,] array = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = random.Next(1, 11);
                }
            }

            Console.WriteLine("\n------------------\n\n\"Array: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
            }
        }

        static int Number11(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        static void Number12()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                numbers.Add(random.Next(1, 101));
            }

            Console.WriteLine("\n------------------\n\n\"Generated numbers:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
