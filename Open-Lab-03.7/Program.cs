using System;

namespace open_lab_03._7
{
    class Program
    {
        public static bool EqualSlices(int total, int people, int each)
        {
            return (people * each <= total);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter total");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter people");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter each");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EqualSlices(a, b, c));
        }

    }
}
