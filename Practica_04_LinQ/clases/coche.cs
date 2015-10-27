using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_04_LinQ.clases
{
    public class Coche
    {
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public int AFabric { get; set; }

        public override string ToString()
        {
            //Dos opciones de hacerlo:

            //return $"{Modelo} con matricula {Matricula} fabricado en {AFabric}";

            return string.Format("\nMatricula:         {0}" +
                                 "\nModelo:            {1}" +
                                 "\nAño Fabricacion:   {2}",
                Matricula, Modelo, AFabric);
        }
    }
}
