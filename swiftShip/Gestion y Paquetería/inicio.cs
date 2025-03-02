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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        //Inicio sesión como administrador o como empleado.
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            iniciar_sesion iniciar_sesion = new iniciar_sesion();
            this.Hide();
            iniciar_sesion.ShowDialog();
            this.Show();
        }

        //Salir del programa.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
