using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdq.clases
{
    internal class Context
    {
        public static List<Alumno> All = new List<Alumno>();

        public static void agregarAlumno(Alumno alumno)
        {
            Context.All.Add(alumno);
        }
    }
}
