using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinamar
{
    internal class Program
    {
        #region Variables de instancia
        static int opcion;
        static double precio = 0;
        static int cantAccesos = 0; 
        static double caja = 0;
        static int accesoValido = 0;
        static int tipoVehiculo = 0;
        static int cantVehic = 0;
        static int dias = 0;
        static double iva = 0, impPecesAconcagua = 0;
        static double acumVehiculos = 0;
        #endregion

        static void Main(string[] args)
        {

            Menu();
            opcion = Convert.ToInt32(Console.ReadLine());
            while (opcion != 4)
            {
                Console.Clear();
                VerificarOpcion(opcion);
                Console.ReadKey();
                Menu();
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Verificar acceso");
            Console.WriteLine("2. Imprimir recaudacion");
            Console.WriteLine("3. Mostrar cantidad de accesos");
            Console.WriteLine("4. Salir ");

        }
        public static void VerificarOpcion(int op)
        {
            switch (op)
            {
                case 1: 
                    Console.WriteLine("Tiene ticket valido?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    accesoValido = Convert.ToInt32(Console.ReadLine());
                    if (accesoValido == 2)
                    {
                        GenerarTicket();
                    }
                    cantAccesos++;
                    break;

                case 2: Console.WriteLine(MostrarCaja());
                    break;

                case 3: Console.WriteLine(MostrarAccesos()); 
                    break;

                case 4: break;

            }
        }
        public static void GenerarTicket()
        {
            Console.Clear();
            acumVehiculos = 0;
            Console.WriteLine("Ingrese el tipo de vehiculo");
            Console.WriteLine("1. Sin Vehículo");
            Console.WriteLine("2. Moto");
            Console.WriteLine("3. Auto");
            Console.WriteLine("4. Camioneta");
            Console.WriteLine("5. Bugy");
            Console.WriteLine("6. Vehículo náutico");
            tipoVehiculo = Convert.ToInt32(Console.ReadLine());

            while(tipoVehiculo != 0) 
            {
                if(tipoVehiculo != 1)
                {
                    Console.WriteLine("Ingrese la cantidad de vehiculos");
                    cantVehic = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Ingrese la cantidad de dias");
                dias = Convert.ToInt32(Console.ReadLine());

                switch (tipoVehiculo)
                {
                    case 1:
                        if (dias == 1)
                        {
                            precio = 100;
                        }
                        if (dias == 2)
                        {
                            precio = 100 * 1.2;
                        }
                        if (dias == 3)
                        {
                            precio = 100 * 2.2;
                        }
                        if (dias == 4)
                        {
                            precio = 100 * 3.2;
                        }
                        if (dias >= 5 && dias <= 10)
                        {
                            precio = 100 * 3.8;
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

                acumVehiculos = acumVehiculos + precio;
                Console.WriteLine("Ingrese el tipo de vehiculo");
                tipoVehiculo = Convert.ToInt32(Console.ReadLine());

            }
            iva = (acumVehiculos * 1.21) - acumVehiculos;
            impPecesAconcagua = (iva * 1.15) - iva;
            acumVehiculos = acumVehiculos + iva + impPecesAconcagua;
            caja = acumVehiculos + caja;
            Console.Clear();
            Console.WriteLine("El valor base es: {0:f2} ", precio);
            Console.WriteLine("El valor del IVA es: {0:f2}", iva);
            Console.WriteLine("El importe de Peces Aconcagua es: {0:f2} ", impPecesAconcagua);
            Console.WriteLine("El valor acumulado de los vehículos es: {0:f2} ", acumVehiculos);
            Console.ReadKey();
            Console.Clear();

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
