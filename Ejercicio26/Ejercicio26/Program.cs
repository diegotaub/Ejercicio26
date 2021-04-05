using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Fecha;
            while (true)
            {
                Console.Write("Ingrese una fecha: ");
                if(DateTime.TryParse(Console.ReadLine(), out Fecha))
                {
                    break;
                }
                Console.WriteLine("Fecha errónea.");
            }
            Console.WriteLine($"Día ingresado: {Fecha.Day}");
            Console.WriteLine($"Nombre de día ingresado: {Fecha.DayOfWeek}");
            Console.WriteLine($"Número de día de la semana ingresado: {Convert.ToInt32(Fecha.DayOfWeek)}");
            Console.WriteLine($"Mes ingresado: {Fecha.Month}");
            Console.WriteLine($"Nombre de Mes ingresado: {Fecha.ToString("MMMM")}");
            Console.WriteLine($"Año ingresado: {Fecha.Year}");
            Console.ReadKey();
        }
    }
}
