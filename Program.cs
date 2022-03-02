using System;

namespace Methots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Hello, user! ******");
            Console.WriteLine("Press to 1 to learn date, Press to 2 to learn time.");
            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.Write("Date : ");
                    ShowDate();
                    break;
                case 2:
                    Console.Write("Time : ");
                    ShowTime();
                    break;
                default:
                    Warning();
                    break;
            }
        }

        private static void Warning()
        {
            Console.WriteLine("\aFalse value.");
        }

        private static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.Date);
        }

        static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.TimeOfDay);
        }
    }


}
