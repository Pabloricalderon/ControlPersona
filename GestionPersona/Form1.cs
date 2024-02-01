using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersona
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void btingresar_Click(object sender, EventArgs e)
        {
            persona.Dpi = txtDPI.Text;
            persona.Nombre = txtnombre.Text;
            persona.Apellido = txtapellido.Text;
            persona.FechaNacimiento = dtpfecha.Value;

           


        }

        private void btmostrar_Click(object sender, EventArgs e)
        {

            lbdpi.Text = persona.Dpi.ToString();
            lbnombre.Text = persona.Nombre.ToString();
            lbapellido.Text = persona.Apellido.ToString();
            lbfecha.Text = persona.FechaNacimiento.ToString();

            lbdpi.Visible = true; lbnombre.Visible = true;
            lbapellido.Visible = true; lbfecha.Visible = true;
        }

        private void btMayusculas_Click(object sender, EventArgs e)
        {
         
            persona.primeraMayuscula();
            lbnombre.Text = persona.Nombre.ToString();
            lbapellido.Text = persona.Apellido.ToString();

        }

        private void btedad_Click(object sender, EventArgs e)
        {
            int edad = persona.edad();
            lbedad.Text = edad.ToString();
            lbedad.Visible = true;

        }

        private void btCorregirNombre_Click(object sender, EventArgs e)
        {
            persona.normalizaNombre();
            lbnombre.Text = persona.Nombre.ToString();
            persona.normalizaApellido();
            lbapellido.Text = persona.Apellido.ToString() ;
        }
    }
}
