using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть X_поч:");
        double xStart = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введiть X_кiн:");
        double xEnd = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введiть крок dX:");
        double step = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("|    x    |    y    |");
        Console.WriteLine("---------------------");

        for (double x = xStart; x <= xEnd; x += step)
        {
            double y;

            if (x <= 4)
            {
                y = 1 + x + Math.Pow(Math.E, Math.Log(2 + 2 * x) + 2 * x);
            }
            else if (4 < x && x <= 7)
            {
                y = 1 + x + 1 / Math.Tan((1 + x) / 9) + 8 * x;
            }
            else
            {
                y = 1 + x + 1 - 7 * x + Math.Pow(x, 2) - 2 * Math.Pow(x, 3);
            }

            Console.WriteLine($"|  {x,-6:F2}  |  {y,-6:F2}  |");
        }
    }
}
