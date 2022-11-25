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

        public int CalculateArea()
        {
            return Width * Height;
        }

        public int CalculatePerimeter()
        {
            return (Width + Height) * 2;
        }
    }
}
