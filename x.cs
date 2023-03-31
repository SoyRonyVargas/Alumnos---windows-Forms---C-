using System.Windows.Forms;
using sdq.clases;
using sdq.forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace sdq
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
    internal partial class x : Form
    {
        public x()
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
                //tabla__alumnos.Rows.Add();
                i++;
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
            if( Context.All.Count == 0 )
            {
                Utils.showDialog("No hay alumnos para dar de baja");
                return;
            }
            
            string matricula = Prompt.ShowDialog("Ingresa la matricula del alumno a eliminar", "");

            Alumno alumnoPorMatricula = Context.All.Where(alumno => alumno.matricula == matricula).FirstOrDefault();

            if ( alumnoPorMatricula == null )
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
    }
}
