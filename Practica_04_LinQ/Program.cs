using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_04_LinQ.clases;

namespace Practica_04_LinQ
{
    internal class Program
    {
        private static List<Coche> listaCoches = new List<Coche>()
        {
            new Coche()
            {
                Matricula = "1234",
                Modelo = "Viper",
                AFabric = 2000,
            },
            new Coche()
            {
                Matricula = "5678",
                Modelo = "Viper",
                AFabric = 2001,
            },
            new Coche()
            {
                Matricula = "9012",
                Modelo = "Cadillac",
                AFabric = 1950,
            },
            new Coche()
            {
                Matricula = "1234",
                Modelo = "Leon",
                AFabric = 1999,
            },
            new Coche()
            {
                Matricula = "1274",
                Modelo = "Corsa",
                AFabric = 2000,
            },
            new Coche()
            {
                Matricula = "8520",
                Modelo = "Viper",
                AFabric = 2000,
            },
            new Coche()
            {
                Matricula = "4556",
                Modelo = "Almera",
                AFabric = 2008,
            },
            new Coche()
            {
                Matricula = "4556",
                Modelo = "Primera",
                AFabric = 2008,
            },
            new Coche()
            {
                Matricula = "9510",
                Modelo = "ZX",
                AFabric = 2011,
            },
            new Coche()
            {
                Matricula = "7588",
                Modelo = "Corsa",
                AFabric = 2014,
            },
            new Coche()
            {
                Matricula = "7599",
                Modelo = "Corsa",
                AFabric = 1999,
            },
            new Coche()
            {
                Matricula = "7530",
                Modelo = "Corsa",
                AFabric = 1999,
            },
            new Coche()
            {
                Matricula = "7511",
                Modelo = "Corsa",
                AFabric = 2014,
            },
            new Coche()
            {
                Matricula = "7531",
                Modelo = "Corsa",
                AFabric = 2014,
            },
            new Coche()
            {
                Matricula = "7537",
                Modelo = "Corsa",
                AFabric = 2014,
            }
        };

        private static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("\n\n*************************MENU**********************\n" +
                                  "Por favor, selecciona una opción.\n\n" +
                                  "\n1.- Buscar por Matrícula" +
                                  "\n2.- Buscar por Modelo" +
                                  "\n3.- Buscar por Modelo y Año de Frabricación" +
                                  "\n4.- Salir");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        BuscarMatricula();
                        Console.ReadLine();
                        break;

                    case 2:
                        BuscarModelo();
                        Console.ReadLine();
                        break;

                    case 3:
                        BuscarModYAñoFab();
                        Console.ReadLine();
                        break;
                }
            } while (op != 4);
        }

        private static void BuscarModYAñoFab()
        {
            Console.WriteLine("\n\nModelo a buscar:");
            var mod = Console.ReadLine();

            Console.WriteLine("\n\n¿Fabricado en que año?:");
            var aFab = Convert.ToInt32(Console.ReadLine());
            
            var resultado = listaCoches.Where(o => o.Modelo == mod && o.AFabric==aFab).OrderByDescending(o => o.Matricula);

            MostrarResultado(resultado);
        }
        
        private static void BuscarModelo()
        {
            Console.WriteLine("\n\nModelo a buscar:");
            var mod = Console.ReadLine();

            var resultado = listaCoches.Where(o => o.Modelo == mod).OrderByDescending(o => o.AFabric);

            MostrarResultado(resultado);
        }

        private static void BuscarMatricula()
        {
            Console.WriteLine("\n\nMatrícula a buscar:");
            var mat = Console.ReadLine();

            var resultado = listaCoches.Where(o => o.Matricula == mat).OrderByDescending(o => o.AFabric);

            MostrarResultado(resultado);
        }

        private static void MostrarResultado(IOrderedEnumerable<Coche> resultado)
        {
            //Se puede comprobar si la lista que devuelve la búsqueda de linq
            //tiene elementos, o no, con el metodo .Any
            if (!resultado.Any())
            {
                foreach (var coche in resultado)
                {

                    Console.WriteLine(coche);


                }
            }
            else
            {
                Console.WriteLine("\n\nNo se han encontrado resultados.\n\n");
            }
        }
    }
}
