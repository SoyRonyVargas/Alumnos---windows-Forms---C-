using System.Windows.Forms;
using System.Linq;
using sdq.clases;
using System;

namespace sdq.forms
{
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Crear_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            if(input__matricula.Text.Count() == 0)
            {
                Utils.showDialog("Ingresa la matricula");
                input__matricula.Focus();
                return;
            }
            
            if (input__nombre.Text.Count() == 0)
            {
                Utils.showDialog("Ingresa el nombre");
                input__nombre.Focus();
                return;
            }

            if (input__grado.Text.Count() == 0)
            {
                Utils.showDialog("Ingresa el grado");
                input__grado.Focus();
                return;
            }

            if(input__grupo.Text.Count() == 0)
            {
                Utils.showDialog("Ingresa el grupo");
                input__grupo.Focus();
                return;
            }

            if (input__promedio.Text.Count() == 0)
            {
                input__promedio.Focus();
                
                Utils.showDialog("Ingresa el promedio");
                
                return;

            }

            Alumno alumno = new Alumno()
            {
                matricula = input__matricula.Text,
                nombre = input__nombre.Text,
                grado = input__grado.Text,
                grupo = input__grupo.Text
            };

            try
            {
                alumno.promedio = double.Parse(input__promedio.Text);
            }
            catch
            {
                Utils.showDialog("Ingresa un promedio valido");
                input__promedio.Text = "";
                return;
            }

            Context.agregarAlumno(alumno);

            Utils.showDialog("Alumno registrado correctamente");

            this.Close();

        }

        private void input__matricula_Click(object sender, EventArgs e)
        {

        }
    }
}
