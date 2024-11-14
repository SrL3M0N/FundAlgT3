using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoloApp1
{
    public class Cita
    {
        public int Num { get; set; }
        internal Estudiante Estudiante { get; set; }
        public string Enf { get; set; }
        public double Pre { get; set; }

        public override string ToString()
        {
            return $"Número: {Num}, Enfermedad: {Enf}, Estudiante: {Estudiante.Nombre}, Universidad: {Estudiante.Universidad}, Precio: {Pre}";
        }
    }

}
