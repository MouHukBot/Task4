using System;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace ex4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выбирите упражнение от 1 до 12: ");
            var task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                        t1();
                        break;
                case 2:
                        t2();
                        break;
                case 3:
                        t3();
                        break;
                case 4:
                        t4();
                        break;
                case 5:
                        t5();
                        break;
                case 6:
                        t6();
                        break;
                case 7:
                        t7();
                        break;
                case 8:
                        t8();
                        break;
                case 9:
                        t9();
                        break;
                case 10:
                        t10();
                        break;
                case 11:
                        t11();
                        break;
                case 12:
                        t12();
                        break;
                default:
                        Console.WriteLine("Вы ввели число что не соответствует условию.");
                        break;
            }
        }
        public static int fun(int a, int b)
        {
            return a + b;
        }
        public static void t1()
        {
            Console.Write("Введите ваш возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваше имя: ");
            var name = Console.ReadLine();
            Console.Write($"Здраствуйте.Вы {name} и вам {age}");
        }
        public static void t2()
        {
            Console.Write("Введите целое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите любое число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите один символ: ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите что вам угодно: ");
            var d = Console.ReadLine();
        }
        public static void t3()
        {
            Console.Write("Напишите что либо: ");
            var inf = (Console.ReadLine());
            int number = 0;
            bool ans = int.TryParse(inf, out number);
            if (ans == false)
            {
                Console.Write("Ошибка");
            }
            else
            {
                Console.Write(number * 2);
            }
        }
        public static void t4()
        {
            Console.Write("Введите любое число");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.Write("Это число равно нулю");
            }
            else if (number > 0)
            {
                Console.Write("Это число является положительным");
            }
            else if (number < 0)
            {
                Console.Write("Это число является отрицательным");
            }
        }
        public static void t5()
        {
            Console.WriteLine("Напишите порядочный номер месяца: ");
            var number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
        public static void t6()
        {
            for (int i = 2; i <= 100; i = i + 2)
            {
                Console.Write(i);
            }
        }
        public static void t7()
        {
            int sum = 0, i = 1;
            while (i <= 50)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine(sum);
        }
        public static void t8()
        {
            int[] A = new int[10];
            for (int i = 0; i < 10; i++)
            {
                A[i] = i + 1;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {A[i]} ");
            }
        }
        public static void t9()
        {
            Random rand100 = new Random();
            int rand = rand100.Next(1, 100);
            Console.WriteLine(rand);
        }
        public static void t10()
        {
            int[,] arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Random rand10 = new Random();
                    int random = rand10.Next(1, 10);
                    arr[i, j] = random;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine("\n");
            }
        }
        public static void t11()
        {
            Console.Write("Введите целое число a: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число b: ");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fun(a, b));
        }
        public static void t12()
        {
            List<int> list = new List<int>();
            int sum = 0;
            for(int i = 0;i < 5;i++)
            {
                Random random = new Random();
                int listrand = random.Next(1, 100);
                list.Add(listrand);
                Console.Write($" {list[i]} ");
                sum += list[i];
            }
            Console.WriteLine($"Сумма: {sum}");
        }
    }
}