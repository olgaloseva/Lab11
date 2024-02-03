using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        //Разработать структуру для решения линейного уравнения 0=kx+b. 
        //Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
        //Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. 
        //Осуществить использование экземпляра в программе.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты:");
            Console.Write("k= ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Equation eq = new Equation(k, b);
            Console.WriteLine(eq.Root());
            Console.ReadKey();
        }
    }
}
