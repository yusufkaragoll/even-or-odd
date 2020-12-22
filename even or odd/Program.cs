using System;

namespace even_or_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 4 == 0)

            {
                Console.Write("Entered number is an even number");
                Console.Read();
            }

            else
            { }

            Console.Write("Entered Number is an odd number ");
            Console.Read();
            //eksik tamamla ve calistir
            //programi tam yazdigindan emin olunca dene ve calistir eksikleri giderip
        }
    }
}
