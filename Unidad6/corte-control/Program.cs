using System;

namespace corte_control
{
    class Program
    {
        static void Main(string[] args)
        {
            //Corte de control:
            //legajo, edad, sueldo, equipo
            int legajo, edad, codigoEquipo, equipoActual;
            float sueldo;
            
            Console.WriteLine("Ingrese el legajo:");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Igrese la edad:");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo:");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el código de equipo:");
            codigoEquipo = int.Parse(Console.ReadLine());
            while (sueldo > 0)
            {
                equipoActual = codigoEquipo;
                while (codigoEquipo == equipoActual)
                {
                Console.WriteLine("Ingrese el legajo:");
                legajo = int.Parse(Console.ReadLine());
                Console.WriteLine("Igrese la edad:");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el sueldo:");
                sueldo = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el código de equipo:");
                codigoEquipo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
