using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionPractica_parteuno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ingresar por teclado
            //bonificacion x12 meses
            
            string nombre;
            int edad;
            string genero;
            string telefono;
            string direccion;
            int anios_empresa;
            double bonificacion;
            double total;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su genero: ");
            genero = Console.ReadLine();

            Console.Write("Ingrese su telefono: ");
            telefono = Console.ReadLine();

            Console.Write("Ingrese su direccion: ");
            direccion = Console.ReadLine();

            Console.Write("Cuanto tiempo ha laborado (digite el numero): ");
            anios_empresa = int.Parse(Console.ReadLine());

            //utilizar switch
            switch (anios_empresa)
            {
                case 5:
                    bonificacion=125.5;
                    total = bonificacion *12;
                    break;
                case 10:
                    bonificacion = 150.6;
                    total = bonificacion*12;
                    break;
                case 15:
                    bonificacion = 170.5;
                    total = bonificacion *12;
                    break;
                case 20:
                    bonificacion  = 190.8;
                    total = bonificacion*12;
                    break;
                default:
                    bonificacion = 0;
                    total = bonificacion *12;
                    break;
            }
            Console.WriteLine("************** DATOS ******************");
            Console.WriteLine("Su nombre es " + nombre);
            Console.WriteLine("Su edad es " + edad);
            Console.WriteLine("Su genero es " + genero);
            Console.WriteLine("Su telefono es " + telefono);
            Console.WriteLine("Su direccion es " + direccion);
            Console.WriteLine("Su monto mensual es " + bonificacion.ToString("c"));
            Console.WriteLine("Su monto anual es " + total.ToString("c"));

            Console.ReadKey();

        }
    }
}
