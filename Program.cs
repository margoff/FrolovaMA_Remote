namespace FrolovaMA
{
    using System;
    class Program
    {
        static void Main()
        {
            double number = 5.0;
            double result = Sqr(number);
            Console.WriteLine($"Квадрат числа {number} равен {result}");
        }

        static public double Sqr(double X)
        {
            return X * X;
        }
        // Frolova Margarita Alekseevna ZAm-1-23
        //<//solve task2>
    }
    
}
