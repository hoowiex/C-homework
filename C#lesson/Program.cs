using System.Numerics;
using System;
using System.Threading;

namespace C_lesson
{
    internal class Program
    {
        static string[,] board;
        static bool[,] revealed;
        static int size;
        static string[] symbols =
        {
        "A", "B", "C", "D", "E", "F", "G", "H",
        "I", "J", "K", "L", "M", "N", "O", "P",
        "Q", "R", "S", "T", "U", "V", "W", "X",
        "Y", "Z", "1", "2", "3", "4", "5", "6"
    };

        static void Main()
        {
            Console.Write("Введите размер игрового поля (четное число, например, 4, 6, 8): ");
            while (!int.TryParse(Console.ReadLine(), out size) || size % 2 != 0 ||  size < 2 || size > 10)
        {
                Console.Write("Некорректный ввод. Введите четное число от 2 до 10: ");
            }

            InitBoard();
            PlayGame();
        }

        static void InitBoard()
        {
            board = new string[size, size];
            revealed = new bool[size, size];

            int pairsCount = (size * size) / 2;
            string[] selectedSymbols = new string[pairsCount * 2];

            // Заполняем массив парами символов
            for (int i = 0; i < pairsCount; i++)
            {
                selectedSymbols[i] = symbols[i];
                selectedSymbols[i + pairsCount] = symbols[i];
            }

            Random rand = new Random();
            for (int i = selectedSymbols.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                string temp = selectedSymbols[i];
                selectedSymbols[i] = selectedSymbols[j];
                selectedSymbols[j] = temp;
            }

            // Заполняем игровое поле
            int index = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = selectedSymbols[index++];
                    revealed[i, j] = false;
                }
            }
        }

        static void PlayGame()
        {
            int pairsFound = 0;
            while (pairsFound < (size * size) / 2)
            {
                Console.Clear();
                PrintBoard();

                Console.Write("Введите координаты первой карты (например, 1 1): ");
                (int x1, int y1) = GetCoordinates();
                revealed[x1, y1] = true;

                Console.Clear();
                PrintBoard();

                Console.Write("Введите координаты второй карты: ");
                (int x2, int y2) = GetCoordinates();
                revealed[x2, y2] = true;

                Console.Clear();
                PrintBoard();
                Thread.Sleep(1000);

                if (board[x1, y1] == board[x2, y2])
                {
                    Console.WriteLine("Вы нашли пару!");
                    pairsFound++;
                }
                else
                {
                    Console.WriteLine("Не совпадает. Попробуйте снова.");
                    revealed[x1, y1] = false;
                    revealed[x2, y2] = false;
                }

                Thread.Sleep(1000);
            }

            Console.WriteLine("Поздравляем! Вы нашли все пары!");
        }

        static void PrintBoard()
        {
            Console.Write("   ");
            for (int i = 0; i < size; i++) Console.Write(i + " ");
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < size; j++)
                {
                    Console.Write(revealed[i, j] ? board[i, j] + " " : "* ");
                }
                Console.WriteLine();
            }
        }

        static (int, int) GetCoordinates()
        {
            while (true)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split();
                if (parts.Length == 2 &&
                    int.TryParse(parts[0], out int x) &&
                    int.TryParse(parts[1], out int y) &&
                    x >= 0 && x < size && y >= 0 && y < size &&
                    !revealed[x, y])
                {
                    return (x, y);
                }
                Console.WriteLine("Некорректный ввод, попробуйте снова.");
            }
        }
    }
}
