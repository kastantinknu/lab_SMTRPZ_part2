using System;

namespace lab_1.v01
{
    class Program
    {
        public static int Reader()
        {
            string s = Console.ReadLine();
            int i = 0;
            try
            {
                i = Int32.Parse(s);
            }
            catch
            {
                Console.WriteLine("Exception.1 int.Parse(number): Input string was not in a correct format.");
            };
            int i2 = Convert.ToInt32(s);
            Console.WriteLine("Method_1: int.Parse(the_entered_number), the result: i={0} \nMethod_2: Convert.ToInt32(the_entered_number), the result: i2={1}", i, i2);
            return i;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number>");
            var i = Reader();
            Console.WriteLine("\nIndependent work.");
            //Перевірити, чи потрапляє змінна, що вводиться, а в інтервал від - 10 до 10(If…else).
            Console.WriteLine("\nThe task 1:");
            if (i < -10 | i > 10)
            {
                Console.WriteLine("The entered number greater than 10 or less than - 10");
            }
            else
            {
                Console.WriteLine("The entered number less than 10 and greater than - 10");
            }
            //Ввести число від 1 до 5, вивести значення англійською(Switch).
            Console.WriteLine("\nThe task 2:");
            Console.Write("Enter a number between 1 and 5>");
            switch (Reader())
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("The entered number is not between 1 and 5");
                    break;
            }
            //Вивести на екран числа Фібоначі(For).
            Console.WriteLine("\nThe task 3:");
            Console.Write("Enter a number>");
            var i2 = Reader();//количество чисел ряда

            int fib1;
            int fib2 = 1;
            int fib_sum = 0;

            for (int j = 0; j < i2; j++)
            {
                Console.WriteLine(fib_sum);
                fib1 = fib2;
                fib2 = fib_sum;
                fib_sum = fib1 + fib2;
            }
            //Побудувати циклічний консольний додаток «Привіт!». Додаток вводить з консолі ім'я «Введіть ім'я»
            //і виводить на консоль рядок вітання, використовуючи введене ім'я. Після вітання на консоль виводиться
            //    запит на продовження роботи «Продовжити роботу? (так, ні)». Залежно від введеної відповіді повторюється
            //    вітання або додаток закінчує роботу.
            Console.WriteLine("\nThe task 4:");
        link1:
            Console.Write("Please, enter your name>");
            string str = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("String is null, empty, or consists only of white-space characters. Please, enter your name again.\n");
                goto link1;
            }
            else
            {
            link2:
                Console.WriteLine($"Hello, {str}");
                Console.WriteLine("Do you want to continue [Y/N]?>");
            link3:
                switch (Console.ReadKey().KeyChar.ToString())
                {
                    case "Y"://y
                        Console.WriteLine();
                        goto link2;
                    case "N"://n
                        return;
                    default:
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("Please, enter again");
                        goto link3;
                }
            }
        }
    }
}
