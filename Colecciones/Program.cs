using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();

            Grupo matematicas =
                new Grupo("Matematicas", "mat123");
            Grupo historia =
                new Grupo("Historia", "hs234");

            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumno juan = new Alumno("Juan", "78921");
            Alumno maria = new Alumno("Maria", "45566");
            Alumno pedro = new Alumno("Pedro", "Maria");
            Alumno chayanne = new Alumno("Elemer", "1234r");
            Alumno patiño = new Alumno("Patiño", "qwrer");

            historia.Alumnos.Add(juan);
            historia.Alumnos.Add(pedro);
            historia.Alumnos.Add(maria);
            
            matematicas.Alumnos.Add(patiño);
            matematicas.Alumnos.Add(chayanne);

            foreach (Grupo grupo in grupos)
            {
                Console.WriteLine("Grupo: " + grupo.Codigo);
                Console.WriteLine("Materia; " + grupo.Materia);
                Console.WriteLine("Lista de alumnos: ");
                foreach (Alumno alumno in grupo.Alumnos)
                {
                    Console.WriteLine("*" + alumno.Nombre);
                }

            }
            Console.Read();
        }
    }
}
