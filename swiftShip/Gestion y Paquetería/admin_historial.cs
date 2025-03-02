using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_y_Paquetería; // Importar el namespace de la clase Envio

namespace Gestion_y_Paquetería
{
    public partial class admin_historial : Form
    {
        //Array para guardar todos los envíos hechos.
        public static string[,] historialEnvios = new string[50, 5];
        //Creo un arreglo de 3 dimensiones para guardar los envíos.
        private Envio[,,] envios;

        public admin_historial(Envio[,,] enviosRecibidos)
        {
            InitializeComponent();
            envios = enviosRecibidos;
        }

        private void admin_historial_Load(object sender, EventArgs e)
        {
            //Inicializo el DataGridView.
            InicializarDataGridView();
        }

        //Inicializo el DataGridView.
        private void InicializarDataGridView()
        {
            dgvHistorial.Columns.Clear();
            dgvHistorial.Columns.Add("Codigo", "Código");
            dgvHistorial.Columns.Add("Destinatario", "Destinatario");
            dgvHistorial.Columns.Add("Direccion", "Dirección");
            dgvHistorial.Columns.Add("Peso", "Peso (kg)");
            dgvHistorial.Columns.Add("Zona", "Zona");
            dgvHistorial.Columns.Add("Estado", "Estado");
            dgvHistorial.Columns.Add("Fecha", "Fecha Registro");
        }

        //Me da la primera posición libre del array historialEnvios.
        private void MostrarEnviosEnGrid()
        {
            //Limpiar el DataGridView
            dgvHistorial.Rows.Clear();

            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        // Obtener el envío en la posición actual
                        Envio envio = envios[i, j, k];

                        // Si el envío no es nulo, mostrarlo en el DataGridView
                        if (envio != null)
                        {
                            int fila = dgvHistorial.Rows.Add(
                                envio.CodigoSeguimiento,
                                envio.Destinatario,
                                envio.Direccion,
                                envio.Peso.ToString("0.00"), // Formatear a 2 decimales
                                envio.Zona,
                                envio.Estado,
                                envio.FechaRegistro.ToString("dd/MM/yyyy HH:mm")
                            );

                            // Aplicar color según el estado
                            if (envio.Estado == "Pendiente") // Si el envío está pendiente, se pone en rojo
                            {
                                dgvHistorial.Rows[fila].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                            }
                            else if (envio.Estado == "En tránsito")//Si el envío está en tránsito, se pone en amarillo
                            {
                                dgvHistorial.Rows[fila].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                            }
                            else if (envio.Estado == "Entregado")//Si el envío está entregado, se pone en verde
                            {
                                dgvHistorial.Rows[fila].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                            }
                        }
                    }
                }
            }
        }

        //Controla el evento de hacer clic en el botón de mostrar historial.
        private void btnMostrarHistorial_Click(object sender, EventArgs e)
        {
            MostrarEnviosEnGrid();
        }
    }
}