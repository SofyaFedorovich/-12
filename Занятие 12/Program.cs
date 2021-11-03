using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_12
{
    class Program
	{
		static void Main(string[] args)
        {
			//модификатор static

			Console.Write("Введите радиус окружности r= ");
			double Radius = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите координату точки Х: ");
			double x = Math.Abs(Convert.ToDouble(Console.ReadLine()));
			Console.Write("Введите координату точки y: ");
			double y = Math.Abs(Convert.ToDouble(Console.ReadLine()));
			Circle.Lenth(Radius);
			Circle.Square(Radius);
			Circle.Position(Radius, x, y);
			Console.ReadKey();

		}

		static class Circle
		{
			public static void Lenth(double Radius)
			{
				double lenthCircle = Math.PI * 2 * Radius;
				Console.WriteLine("Длина окружности с заданным радиусом равна {0:f2}", lenthCircle);
			}
			public static void Square(double Radius)
			{
				double Square = Math.PI * Math.Pow(Radius, 2.0);
				Console.WriteLine("Площадь круга с заданным радиусом равна {0:f2}", Square);
			}

			public static void Position(double Radius, double x, double y)
			{
				if (x <= Radius && y <= Radius)
				{
					Console.WriteLine("Точка с координатами ({0},{1}) принадлежит кругу с заданным  радиусом {2}", x, y, Radius);
				}
				else
				{
					Console.WriteLine("Точка с координатами ({0},{1}) не принадлежит кругу с заданным радиусом {2}", x, y, Radius);
				}
			}
		}
	}
}
