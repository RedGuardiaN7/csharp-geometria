//Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo.
//Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
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
