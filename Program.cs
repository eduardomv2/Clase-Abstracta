using Clase_Abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p = new Perro();
            p.Nombre = "Fido";
            p.Edad = 3;
            p.HacerSonido();
            
            Gato g = new Gato();
            g.Nombre = "Tom";
            g.Edad = 2;
            g.HacerSonido();     
                       
        }        
    }
}
