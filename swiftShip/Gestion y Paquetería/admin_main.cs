using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_y_Paquetería;

namespace Gestion_y_Paquetería
{
    public partial class admin_main : Form
    {
        public admin_main()
        {
            InitializeComponent();
        }

        private void admin_main_Load(object sender, EventArgs e)
        {

        }

        //En este formulario entran como administradores a ver el historial de envíos.
        private void btnHistorialEnvios_Click(object sender, EventArgs e)
        {
            admin_historial admin_historial = new admin_historial(admin_ingreso_de_datos.envios);
            this.Hide();
            admin_historial.ShowDialog();
            this.Show();
        }


        //En este formulario yo entro como administrador a ingresar envíos nuevos, y con un clic
        //puedo calcular los precios de los envíos que se han hecho.
        private void btnIngresoDatos_Click(object sender, EventArgs e)
        {
            admin_ingreso_de_datos admin_ingreso_de_datos = new admin_ingreso_de_datos();
            this.Hide();
            admin_ingreso_de_datos.ShowDialog();
            this.Show();

        }

    }
}
