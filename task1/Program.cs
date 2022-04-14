using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите градусы: ");
            int gradus_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты дуги: ");
            int min_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите угловые секунды: ");
            int sec_ = Convert.ToInt32(Console.ReadLine());

            RadianCalc radianCalc = new RadianCalc(gradus_, min_, sec_);

            Console.Write($"Угол в радианах равен: {radianCalc.ToRadiant()}");

        }
    }
}
