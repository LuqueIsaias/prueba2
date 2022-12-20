using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;


            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;



            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;


            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;

            if (txtApellido.Text == "" || txtDireccion.Text == "" || txtNombre.Text == "" || txtEdad.Text == "")
                MessageBox.Show("Faltan completar datos");
            else
            txtResultado.Text = "Apellido y Nombre: " + txtApellido.Text.ToUpper() + " " + txtNombre.Text.ToUpper()+ "\r\n" + "Edad: " + txtEdad.Text.ToUpper()+ "\r\n" + "Direccion: " + txtDireccion.Text.ToUpper();
                
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.White;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            txtEdad.BackColor = Color.White;
        }

       

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.BackColor = Color.White;

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
