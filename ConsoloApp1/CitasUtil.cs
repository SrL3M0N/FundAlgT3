using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoloApp1
{
    internal class CitasUtil
    {
        public static void CrearCita(Cita[] citas, ref int totalCitas)
        {
            if (totalCitas >= citas.Length)
            {
                Console.WriteLine("No se pueden agregar más citas.");
                return;
            }

            Console.Write("Ingrese el número de la cita: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el código del estudiante: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la universidad del estudiante: ");
            string universidad = Console.ReadLine();

            Console.Write("Ingrese la enfermedad: ");
            string enfermedad = Console.ReadLine();

            Console.Write("Ingrese el precio: ");
            double precio = double.Parse(Console.ReadLine());
            
            Estudiante estudiante = new Estudiante { Cod = codigo, Nom = nombre, Uni = universidad };
            Cita cita = new Cita { Num = numero, Estudiante = estudiante, Enf = enfermedad, Pre = precio };

            citas[totalCitas] = cita;
            totalCitas++;

            Console.WriteLine("Cita se ha creado con éxito.");
        }

    }
}
