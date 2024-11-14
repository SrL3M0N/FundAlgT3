using ConsoloApp1;
using System;

namespace GestionCitasMedicas
{
    class Program
    {
        static void Main(string[] args)
        {

            Cita[] citas = new Cita[100];
            int totalCitas = 0;

            int opcion;
            do
            {
                Console.WriteLine(" Menú de citas medicas ");
                Console.WriteLine("1) Crear ");
                Console.WriteLine("2) Listar ");
                Console.WriteLine("3) Modificar ");
                Console.WriteLine("4) Fin");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        CitasUtil.CrearCita(citas, ref totalCitas);
                        break;

                    case 2:

                        CitasUtil.ListarCitas(citas, totalCitas);
                        break;

                    case 3:

                        Console.Write("Ingrese el texto a buscar : ");
                        string textoBuscar = Console.ReadLine();
                        Console.Write("Ingrese el texto de reemplazo: ");
                        string textoReemplazo = Console.ReadLine();
                        CitasUtil.ModificarMasivoUniversidad(citas, totalCitas, textoBuscar, textoReemplazo);
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
