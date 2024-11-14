using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoloApp1
{
    internal class Estudiante
    {
        public int Cod { get; set; }
        public string Nom { get; set; }
        public string Uni { get; set; }

        public override string ToString()
        {
            return $"Código: {Cod}, Nombre: {Nom}, Universidad: {Uni}";
        }
    }

}
