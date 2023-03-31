using sdq.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdq.forms
{
   
    internal partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Crear form_crear = new Crear();
            form_crear.ShowDialog();
        }

        public void renderTable()
        {
            List<Alumno> alumnos = Context.All;

            Ordenamiento.OrdenarDescendente(alumnos);

            tabla__alumnos.Rows.Add();

            int i = 0;

            foreach (Alumno alumno in alumnos)
            {
                tabla__alumnos.Rows[i].Cells[0].Value = alumno.matricula;
                tabla__alumnos.Rows[i].Cells[1].Value = alumno.nombre;
                tabla__alumnos.Rows[i].Cells[2].Value = alumno.grado;
                tabla__alumnos.Rows[i].Cells[3].Value = alumno.grupo;
                tabla__alumnos.Rows[i].Cells[4].Value = alumno.promedio;
                i++;
            }

        }



        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabla__alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAsc_Click(object sender, EventArgs e)
        {

            List<Alumno> alumnos = Context.All;

            Ordenamiento.OrdenarAscendente(alumnos);

            //tabla__alumnos.Rows.Clear();

            int i = 0;

            foreach (Alumno alumno in alumnos)
            {
                tabla__alumnos.Rows[i].Cells[0].Value = alumno.matricula;
                tabla__alumnos.Rows[i].Cells[1].Value = alumno.nombre;
                tabla__alumnos.Rows[i].Cells[2].Value = alumno.grado;
                tabla__alumnos.Rows[i].Cells[3].Value = alumno.grupo;
                tabla__alumnos.Rows[i].Cells[4].Value = alumno.promedio;
                i++;
            }

        }

        public string calcularString(List<Alumno> alumnos)
        {
            string str = "";
            foreach( Alumno alumno in alumnos )
            {
                str += $"Matricula: {alumno.matricula} \n";
                str += $"Nombre: {alumno.nombre} \n";
                str += $"Grado: {alumno.grado} \n";
                str += $"Grupo: {alumno.grupo} \n";
                str += $"Promedio: {alumno.promedio} \n";
            }
            return str;
        }
        public static void EscribirArchivoEnEscritorio(string contenido , string file)
        {
            // Obtiene la ruta del escritorio del usuario
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Crea el nombre del archivo
            string nombreArchivo = file;

            // Combina la ruta del escritorio con el nombre del archivo
            string rutaArchivo = Path.Combine(escritorio, nombreArchivo);

            // Escribe el contenido en el archivo
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                sw.Write(contenido);
            }
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            List<Alumno> alumnos = Context.All;

            Ordenamiento.OrdenarDescendente(alumnos);

            int i = 0;

            foreach (Alumno alumno in alumnos)
            {
                tabla__alumnos.Rows[i].Cells[0].Value = alumno.matricula;
                tabla__alumnos.Rows[i].Cells[1].Value = alumno.nombre;
                tabla__alumnos.Rows[i].Cells[2].Value = alumno.grado;
                tabla__alumnos.Rows[i].Cells[3].Value = alumno.grupo;
                tabla__alumnos.Rows[i].Cells[4].Value = alumno.promedio;
                i++;
            }

           
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (Context.All.Count == 0)
            {
                Utils.showDialog("No hay alumnos para dar de baja");
                return;
            }

            string matricula = Prompt.ShowDialog("Ingresa la matricula del alumno a eliminar", "");

            Alumno alumnoPorMatricula = Context.All.Where(alumno => alumno.matricula == matricula).FirstOrDefault();

            if (alumnoPorMatricula == null)
            {
                Utils.showDialog("No se encontro el alumno");
                return;
            }

            Context.All.Remove(alumnoPorMatricula);

            Utils.showDialog("Alumno eliminado correctamente");

            List<Alumno> alumnos = Context.All;

            Ordenamiento.OrdenarAscendente(alumnos);

            tabla__alumnos.Rows.Clear();

            int i = 0;

            foreach (Alumno alumno in alumnos)
            {
                tabla__alumnos.Rows.Add();
                tabla__alumnos.Rows[i].Cells[0].Value = alumno.matricula;
                tabla__alumnos.Rows[i].Cells[1].Value = alumno.nombre;
                tabla__alumnos.Rows[i].Cells[2].Value = alumno.grado;
                tabla__alumnos.Rows[i].Cells[3].Value = alumno.grupo;
                tabla__alumnos.Rows[i].Cells[4].Value = alumno.promedio;
                //tabla__alumnos.Rows.Add();
                i++;
            }

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {

            if (Context.All.Count == 0)
            {
                Utils.showDialog("No hay alumnos para buscar");
                return;
            }

            string matricula = Prompt.ShowDialog("Ingresa la matricula del alumno a buscar", "");

            Alumno alumnoPorMatricula = Context.All.Where(alumno => alumno.matricula == matricula).FirstOrDefault();

            if(  alumnoPorMatricula == null )
            {
                Utils.showDialog("El alumno que buscas no se encuentra");
                return;
            }

            List<Alumno> a = new List<Alumno>();
            
            a.Add(alumnoPorMatricula);

            string str = calcularString(a);

            Main.EscribirArchivoEnEscritorio(str, "alumno_busqueda.txt");

            Utils.showDialog($@"
                Datos del alumno:
                Matricula: {alumnoPorMatricula.matricula}
                Nombre: {alumnoPorMatricula.nombre}
                Grado: {alumnoPorMatricula.grado}
                Grupo: {alumnoPorMatricula.grupo}
                Promedio: {alumnoPorMatricula.promedio}
            ");

            Utils.showDialog("Se genero un archivo con los datos en el escritorio (alumno_busqueda.txt)");


        }
    }
}
