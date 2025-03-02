using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_y_Paquetería
{
    public partial class iniciar_sesion : Form
    {
        public iniciar_sesion()
        {
            InitializeComponent();
            //Inicializa los caracteres de la contraseña como asteriscos
            txtContrasena.PasswordChar = '*';
        }

        private void chkContra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContra.Checked == true)
            {
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                txtContrasena.PasswordChar = '*';
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Convierte los datos ingresados a minúsculas
            txtContrasena.Text = txtContrasena.Text.ToLower();
            txtNombreUsuario.Text = txtNombreUsuario.Text.ToLower();
            //Asigna los datos ingresados a variables
            string usuario = txtNombreUsuario.Text;
            string contrasena = txtContrasena.Text;

            //Compara los datos ingresados con los datos de usuario y contraseña
            if (usuario == "admin" && contrasena == "admin")
            {
                MessageBox.Show("Bienvenido, admin.", "Inicio de sesión exitoso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Redirecciona a la ventana de ingreso de datos
                ingreso_de_datos ingreso_de_datos = new ingreso_de_datos();
                this.Hide();
                ingreso_de_datos.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            inicio inicio = new inicio();
            this.Hide();
            inicio.ShowDialog();
            this.Show();

        }

        private void iniciar_sesion_Load(object sender, EventArgs e)
        {

        }
    }
}
