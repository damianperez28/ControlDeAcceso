using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinamar
{
    internal class Program
    {
        static int opcion;
        static double precio = 0;
        static int cantAccesos = 0; 
        static double caja = 0;
        static int accesoValido = 0;
        static int tipoVehiculo = 0;
        static int cantVehiculos = 0;
        static int cantDias = 0;
        static double iva = 0, impPecesAconcagua = 0;


        static void Main(string[] args)
        {

            Menu();
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion) 
            {
                case 1:
                    Console.WriteLine("Tiene acceso valido?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    accesoValido = Convert.ToInt32(Console.ReadLine());

                    if (accesoValido == 2)
                    {
                        Console.WriteLine("Ingrese el tipo de vehiculo");
                        tipoVehiculo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de vehiculos");
                        cantVehiculos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de dias");
                        cantDias = Convert.ToInt32(Console.ReadLine());

                        GenerarTicket(tipoVehiculo, cantVehiculos, cantDias);
                    }
                    break;

            }

        }

        public static void Menu()
        {
            Console.WriteLine("1. Verificar acceso");
            Console.WriteLine("2. Imprimir recaudacion");
            Console.WriteLine("3. Mostrar cantidad de accesos");
            Console.WriteLine("4. Salir ");
        }

        public static void Operaciones()
        {

        }

        public static void GenerarTicket(int tipo, int cantVehic, int dias)
        {

            switch (tipo)
            {
                case 1:
                    if (dias == 1)
                    {
                        precio = 100 * cantVehic;
                    }
                    if (dias == 2)
                    {
                        precio = 100 * 1.2 * cantVehic;
                    }
                    if (dias == 3)
                    {
                        precio = 100 * 2.2 * cantVehic;
                    }
                    if (dias == 4)
                    {
                        precio = 100 * 3.2 * cantVehic;
                    }
                    if (dias >= 5 && dias <= 10)
                    {
                        precio = 100 * 3.8 * cantVehic;
                    }
                    break;

                case 2:
                    if (dias == 1)
                    {
                        precio = 800 * cantVehic;
                    }
                    if (dias == 2)
                    {
                        precio = 800 * 1.2 * cantVehic;
                    }
                    if (dias == 3)
                    {
                        precio = 800 * 2.2 * cantVehic;
                    }
                    if (dias == 4)
                    {
                        precio = 800 * 3.2 * cantVehic;
                    }
                    if (dias >= 5 && dias <= 10)
                    {
                        precio = 800 * 3.8 * cantVehic;
                    }
                    break;

                case 3:
                    if (dias == 1)
                    {
                        precio = 1000 * cantVehic;
                    }
                    if (dias == 2)
                    {
                        precio = 1000 * 1.2 * cantVehic;
                    }
                    if (dias == 3)
                    {
                        precio = 1000 * 2.2 * cantVehic;
                    }
                    if (dias == 4)
                    {
                        precio = 1000 * 3.2 * cantVehic;
                    }
                    if (dias >= 5 && dias <= 10)
                    {
                        precio = 1000 * 3.8 * cantVehic;
                    }
                    break;

                case 4:
                    if (dias == 1)
                    {
                        precio = 1500;
                    }
                    if (dias == 2)
                    {
                        precio = 1500 * 1.2 * cantVehic;
                    }
                    if (dias == 3)
                    {
                        precio = 1500 * 2.2 * cantVehic;
                    }
                    if (dias == 4)
                    {
                        precio = 1500 * 3.2 * cantVehic;
                    }
                    if (dias >= 5 && dias <= 10)
                    {
                        precio = 1500 * 3.8 * cantVehic;
                    }
                    break;

                case 5:
                    if (dias == 1)
                    {
                        precio = 5000 * cantVehic;
                    }
                    if (dias == 2)
                    {
                        precio = 5000 * 1.2 * cantVehic;
                    }
                    if (dias == 3)
                    {
                        precio = 5000 * 2.2 * cantVehic;
                    }
                    if (dias == 4)
                    {
                        precio = 5000 * 3.2 * cantVehic;
                    }
                    if (dias >= 5 && dias <= 10)
                    {
                        precio = 5000 * 3.8 * cantVehic;
                    }
                    break;

                case 6:
                    if (dias == 1)
                    {
                        precio = 1200 * cantVehic;
                    }
                    if (dias == 2)
                    {
                        precio = 1200 * 1.2 * cantVehic;
                    }
                    if (dias == 3)
                    {
                        precio = 1200 * 2.2 * cantVehic;
                    }
                    if (dias == 4)
                    {
                        precio = 1200 * 3.2 * cantVehic;
                    }
                    if (dias >= 5 && dias <= 10)
                    {
                        precio = 1200 * 3.8 * cantVehic;
                    }
                    break;
            }

            iva = precio * 1.21;
            impPecesAconcagua = iva * 1.15;
        }

        public static double MostrarCaja()
        {
            return caja;
        }
        public static int MostrarAccesos()
        {
            return cantAccesos;
        }
    }
}
