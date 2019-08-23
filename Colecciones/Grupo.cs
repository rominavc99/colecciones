using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Grupo
    {
        public string Materia { get; set; }
        public string Codigo { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public Grupo(string materia, string codigo)
        {
            Codigo = codigo;
            Materia = materia;
            Alumnos = new List<Alumno>();

           
        }

        
    }
}
