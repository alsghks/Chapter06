using System;

namespace SwapByValue
{
    class MainApp
    {
        public static void swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");

            swap(x, y);

            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}
