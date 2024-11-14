using ConsoloApp1;
using System;

namespace GestionCitasMedicas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cita[] citas = new Cita[100];
            int totalCitas = 0; // Contador para las citas creadas

            int opcion;
            do
            {
                Console.WriteLine("\n--- Menú de Gestión de Citas Médicas ---");
                Console.WriteLine("1. Crear Cita");
                Console.WriteLine("2. Listar Citas");
                Console.WriteLine("3. Modificar Masivo de Universidades");
                Console.WriteLine("4. Fin");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Llamada al método CrearCita de CitaUtil
                        CitaUtil.CrearCita(citas, ref totalCitas);
                        break;

                    case 2:
                        // Llamada al método ListarCitas de CitaUtil
                        CitaUtil.ListarCitas(citas, totalCitas);
                        break;

                    case 3:
                        // Llamada al método ModificarMasivoUniversidad de CitaUtil
                        Console.Write("Ingrese el texto a buscar en universidades: ");
                        string textoBuscar = Console.ReadLine();
                        Console.Write("Ingrese el texto de reemplazo: ");
                        string textoReemplazo = Console.ReadLine();
                        CitaUtil.ModificarMasivoUniversidad(citas, totalCitas, textoBuscar, textoReemplazo);
                        break;

                    case 4:
                        Console.WriteLine("Fin del programa.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
