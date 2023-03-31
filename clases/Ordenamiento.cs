using System.Collections.Generic;
using sdq.clases;

namespace sdq.clases
{
    internal class Ordenamiento
    {
        public static void OrdenarAscendente(List<Alumno> alumnos)
        {
            for (int i = 0; i < alumnos.Count - 1; i++)
            {
                int indiceMenor = i;
                for (int j = i + 1; j < alumnos.Count; j++)
                {
                    if (alumnos[j].promedio < alumnos[indiceMenor].promedio)
                    {
                        indiceMenor = j;
                    }
                }
                if (indiceMenor != i)
                {
                    Alumno temp = alumnos[i];
                    alumnos[i] = alumnos[indiceMenor];
                    alumnos[indiceMenor] = temp;
                }
            }
        }

        public static void OrdenarDescendente(List<Alumno> alumnos)
        {
            for (int i = 0; i < alumnos.Count - 1; i++)
            {
                int indiceMayor = i;
                for (int j = i + 1; j < alumnos.Count; j++)
                {
                    if (alumnos[j].promedio > alumnos[indiceMayor].promedio)
                    {
                        indiceMayor = j;
                    }
                }
                if (indiceMayor != i)
                {
                    Alumno temp = alumnos[i];
                    alumnos[i] = alumnos[indiceMayor];
                    alumnos[indiceMayor] = temp;
                }
            }
        }
    }
}
