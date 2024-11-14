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
        public static void ListarCitas(Cita[] citas, int totalCitas)
        {
            if (totalCitas == 0)
            {
                Console.WriteLine("No hay citas registradas.");
                return;
            }

            double sumaPrecios = 0;

            Console.WriteLine("Listado de Citas Médicas:");
            for (int i = 0; i < totalCitas; i++)
            {
                
                Console.WriteLine($"Número de Cita: {citas[i].Num}");
                Console.WriteLine($"Enfermedad: {citas[i].Enf}");
                Console.WriteLine($"Nombre del Estudiante: {citas[i].Estudiante.Nom}");
                Console.WriteLine($"Universidad: {citas[i].Estudiante.Uni}");
                Console.WriteLine($"Precio: {citas[i].Pre:C}");
                Console.WriteLine();  

                
                sumaPrecios += citas[i].Pre;
            }

            
            Console.WriteLine($"Total de precios: {sumaPrecios:C}");
        }
        public static void ModificarMasivoUniversidad(Cita[] citas, int totalCitas, string textoBuscar, string textoReemplazo)
        {
            bool modificacionRealizada = false;

            
            for (int i = 0; i < totalCitas; i++)
            {
                
                if (citas[i].Estudiante.Uni.Contains(textoBuscar))
                {
                    
                    citas[i].Estudiante.Uni = citas[i].Estudiante.Uni.Replace(textoBuscar, textoReemplazo);
                    modificacionRealizada = true;
                }
            }

           
            if (modificacionRealizada)
            {
                Console.WriteLine("Las universidades fueron modificadas correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontraron universidades que coincidan con el texto de búsqueda.");
            }
        }


    }
}
