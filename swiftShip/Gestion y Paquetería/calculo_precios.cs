using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gestion_y_Paquetería.ingreso_de_datos;
using Gestion_y_Paquetería;

namespace Gestion_y_Paquetería
{
    public partial class calculo_precios : Form
    {
        private Envio[,,] envios;

        // Diccionario con tarifas por zona
        private Dictionary<string, double> tarifasPorZona = new Dictionary<string, double>()
        {
            { "Zona Norte", 3.50 },
            { "Zona Sur", 4.00 },
            { "Zona Este", 3.00 },
            { "Zona Oeste", 3.80 },
            { "Zona Central", 2.50 }
        };

        public calculo_precios(Envio[,,] enviosRecibidos)
        {
            InitializeComponent();
            envios = enviosRecibidos;
        }

        private void calculo_precios_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MostrarDatosYCalculos();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void MostrarDatosYCalculos()
        {
            lbDatosPrecio.Items.Clear();
            dgvDatos.DataSource = null;

            List<Envio> listaEnvios = new List<Envio>();
            double precioTotal = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (envios[i, j, k] != null)
                        {
                            var envio = envios[i, j, k];

                            double precio = CalcularPrecio(envio.Peso, envio.Zona);
                            precioTotal += precio;

                            listaEnvios.Add(envio);
                            lbDatosPrecio.Items.Add($"Código: {envio.CodigoSeguimiento} | Zona: {envio.Zona} | Peso: {envio.Peso} kg | Precio: ${precio:F2}");
                        }
                    }
                }
            }

            dgvDatos.DataSource = listaEnvios;
            lblTotalPrecios.Text = $"Total: {precioTotal:F2}";

        }

        private double CalcularPrecio(double peso, string zona)
        {
            if (tarifasPorZona.ContainsKey(zona))
            {
                return peso * tarifasPorZona[zona];
            }
            else
            {
                MessageBox.Show("Zona no reconocida, usando tarifa estándar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return peso * 3.00; // Fallback por si hay un error.
            }
        }

        private void GenerarReporte()
        {
            int totalEnvios = 0;
            int[] enviosPorEstado = new int[3]; 
            int[] enviosPorZona = new int[5];
            double totalPeso = 0;

            for (int i = 0;  i < 50;  i++)
            {
                for (int j = 0; j < 5; j++) //Zonas
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (envios[i, j, k] != null)
                        {
                            totalEnvios++;
                            enviosPorZona[j]++;
                            enviosPorEstado[k]++;
                            totalPeso += envios[i, j, k].Peso;
                        }
                    }
                }
                
            }


            double pesoPromedio = (totalEnvios > 0) ? totalPeso / totalEnvios : 0;

            // Crear el texto del reporte
            string reporte = "📦 Reporte de Envíos 📦\n";
            reporte += "----------------------------\n";
            reporte += $"Total envíos: {totalEnvios}\n";
            reporte += $"Envíos pendientes: {enviosPorEstado[0]}\n";
            reporte += $"Envíos en tránsito: {enviosPorEstado[1]}\n";
            reporte += $"Envíos entregados: {enviosPorEstado[2]}\n\n";
            reporte += "Total por zona:\n";
            reporte += $"- Zona Norte: {enviosPorZona[0]} envíos\n";
            reporte += $"- Zona Sur: {enviosPorZona[1]} envíos\n";
            reporte += $"- Zona Este: {enviosPorZona[2]} envíos\n";
            reporte += $"- Zona Oeste: {enviosPorZona[3]} envíos\n";
            reporte += $"- Zona Central: {enviosPorZona[4]} envíos\n\n";
            reporte += $"Peso promedio: {pesoPromedio:F2} lbs";

            MessageBox.Show(reporte, "Reporte Resumido", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
