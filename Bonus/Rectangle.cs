//BONUS: Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    public class Rectangle
    {
        public int Width;
        public int Height;
        public int area;
        public int perimeter;

        public int CalculateArea()
        {
            int area = Width * Height;
            return area;
        }

        public int CalculatePerimeter()
        {
            int perimeter = (Width + Height) * 2;
            return perimeter;
        }

        public void Print(int num)
        {
            Console.WriteLine("--------- Rettangolo " + num + " ---------");
            Console.WriteLine("Base: \t \t" + Width + " cm");
            Console.WriteLine("Altezza: \t" + Height + " cm");
            Console.WriteLine("Perimetro: \t" + perimeter + " cm");
            Console.WriteLine("Area: \t \t" + area + " cm^2");
            Console.WriteLine();
        }
    }
}
