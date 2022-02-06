using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20.Делегаты__события__лямбды
{
    internal class Program
    {
        delegate double Circle(double Radius);
        static void Main(string[] args)
        {
            repeat:
            Circle circle = Length;
            circle += Area;
            circle += Volume;
            Console.WriteLine("ведите радиус окружности:");
            double radius = Convert.ToDouble(Console.ReadLine());
            circle(radius);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nНажмите <Enter>, если хотите сбросить результат и начать заново\nДля выхода, нажмите любую клавишу...");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                goto repeat;
            }

        }

        static double Length(double radius)
        {
            double L = 2 * Math.PI * radius;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nДлина окружности L={String.Format("{0:f}", L)};");
            return L;
        }
        static double Area(double radius)
        {
            double S = Math.PI * Math.Pow(radius, 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nПлощадь круга S={String.Format("{0:f}", S)};");
            return S;
        }        
        static double Volume(double radius)
        {
            double V = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nОбъем шара V={String.Format("{0:f}", V)};");
            return V;
        }

    }
}

