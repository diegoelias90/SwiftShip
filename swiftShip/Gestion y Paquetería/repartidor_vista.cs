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
    public partial class repartidor_vista : Form
    {
        public static Envio[,,] enviosGlobales;

        private Envio[,,] envios;
        private string[] estados = { "Pendiente", "En tránsito", "Entregado" };
        public repartidor_vista(Envio[,,] enviosRecibidos)
        {
            InitializeComponent();
            envios = enviosRecibidos;

            // Guardar referencia global
            enviosGlobales = enviosRecibidos;

            CargarEstados();
            ActualizarListaEnvios();
        }

        private void repartidor_vista_Load(object sender, EventArgs e)
        {
            cbNuevoEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarEstados()
        {
            cbNuevoEstado.Items.AddRange(estados);
            cbNuevoEstado.SelectedIndex = 0;
        }

        private void ActualizarListaEnvios()
        {
            List<Envio> listaTemporal = new List<Envio>();

            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (envios[i, j, k] != null)
                        {
                            listaTemporal.Add(envios[i, j, k]);
                        }
                    }
                }
            }

            dgvEnviosRepartidor.DataSource = null;
            dgvEnviosRepartidor.DataSource = listaTemporal;
        }

        private void btnModificarEstado_Click(object sender, EventArgs e)
        {
            if (dgvEnviosRepartidor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un envío para modificar su estado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Envio envioSeleccionado = (Envio)dgvEnviosRepartidor.SelectedRows[0].DataBoundItem;
            string codigoSeguimiento = envioSeleccionado.CodigoSeguimiento;
            int nuevoEstadoIndex = cbNuevoEstado.SelectedIndex;

            bool modificado = ModificarEstadoEnvio(codigoSeguimiento, nuevoEstadoIndex);

            if (modificado)
            {
                MessageBox.Show("Estado del envío modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListaEnvios();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el estado del envío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ModificarEstadoEnvio(string codigo, int nuevoEstadoIndex)
        {
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (envios[i, j, k] != null && envios[i, j, k].CodigoSeguimiento == codigo)
                        {
                            // Guarda los datos del envío actual
                            Envio envioActual = envios[i, j, k];

                            // Elimina el envío de su posición actual
                            envios[i, j, k] = null;

                            // Crea un nuevo envío con el estado actualizado
                            Envio envioActualizado = new Envio
                            {
                                CodigoSeguimiento = envioActual.CodigoSeguimiento,
                                Destinatario = envioActual.Destinatario,
                                Direccion = envioActual.Direccion,
                                Peso = envioActual.Peso,
                                Zona = envioActual.Zona,
                                Estado = estados[nuevoEstadoIndex],
                                FechaRegistro = envioActual.FechaRegistro
                            };

                            // Guarda el envío actualizado en la nueva posición
                            envios[i, j, nuevoEstadoIndex] = envioActualizado;

                            return true;
                        }
                    }
                }
            }
            return false;
        }


    }
}
