using System;

namespace KURS

{

    class Program
    {

        static void Main()
        {

            Console.Write("Введите радиус круга: ");
        
            string s = Console.ReadLine();

            double r = Convert.ToDouble(s);

            double p = Math.PI * r * r;

            Console.WriteLine("Площадь круга = {0}", p);

            Console.ReadLine();

            return;

        }

    }

}