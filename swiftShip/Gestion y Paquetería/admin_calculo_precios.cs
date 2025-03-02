using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gestion_y_Paquetería.admin_ingreso_de_datos;
using Gestion_y_Paquetería; // Importar el namespace de la clase Envio

namespace Gestion_y_Paquetería
{
    public partial class admin_calculo_precios : Form
    {
        //Creo un arreglo de 3 dimensiones para guardar los envíos.
        public Envio[,,] envios;

        // Diccionario con tarifas por zona
        private Dictionary<string, double> tarifasPorZona = new Dictionary<string, double>()
        {
            { "Zona Norte", 3.50 },
            { "Zona Sur", 4.00 },
            { "Zona Este", 3.00 },
            { "Zona Oeste", 3.80 },
            { "Zona Central", 2.50 }
        };

        public admin_calculo_precios(Envio[,,] enviosRecibidos)
        {
            InitializeComponent();
            envios = enviosRecibidos;
        }

        private void calculo_precios_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MostrarDatosYCalculos(); //Muestra los datos y los cálculos (declarado en la parte de abajo)
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            GenerarReporte(); //Genera un reporte (declarado en la parte de abajo). 
            // Esta es la nueva funcionalidad.
        }

        //Método que me muestra los datos y calculos en el ListBox y en el DataGridView.
        private void MostrarDatosYCalculos()
        {
            lbDatosPrecio.Items.Clear();
            dgvDatos.DataSource = null;

            // Lista temporal para almacenar los envíos y calcular el precio total.
            List<Envio> listaEnvios = new List<Envio>();
            // Variable para almacenar el precio total de los envíos.
            double precioTotal = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        // Si hay un envío en esa posición, calcular el precio y mostrarlo.
                        if (envios[i, j, k] != null)
                        {
                            // Le da una variable al array para poder acceder a los datos.
                            var envio = envios[i, j, k];

                            // Calcular el precio del envío según la zona y el peso guardados en el diccionario
                            double precio = CalcularPrecio(envio.Peso, envio.Zona);
                            // Sumar el precio al total
                            precioTotal += precio;

                            // Agregar el envío a la lista y mostrarlo en el ListBox
                            listaEnvios.Add(envio);
                            // Agregar el precio al ListBox
                            lbDatosPrecio.Items.Add($"Código: {envio.CodigoSeguimiento} | Zona: {envio.Zona} | Peso: {envio.Peso} kg | Precio: ${precio:F2}");
                        }
                    }
                }
            }

            // Mostrar la lista de envíos en el DataGridView y el precio total en el label
            dgvDatos.DataSource = listaEnvios;
            lblTotalPrecios.Text = $"Total: {precioTotal:F2}"; //F:2 para que solo muestre 2 decimales.

        }

        //Método para calcular el precio de los envíos.
        private double CalcularPrecio(double peso, string zona)
        {
            // Si la zona está en el diccionario, calcular el precio con la tarifa correspondiente.
            if (tarifasPorZona.ContainsKey(zona))
            {
                // Multiplicar el peso por la tarifa de la zona
                return peso * tarifasPorZona[zona];
            }
            else
            {
                // Si la zona no está en el diccionario, mostrar un mensaje de advertencia y usar una tarifa estándar.
                MessageBox.Show("Zona no reconocida, usando tarifa estándar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return peso * 3.00; // Default por si hay un error.
            }
        }

        //Método para generar un reporte resumido de los envíos (nueva funcionalidad).
        private void GenerarReporte()
        {
            // Contadores para los envíos, estados, zonas y peso total
            int totalEnvios = 0;
            int[] enviosPorEstado = new int[3]; 
            int[] enviosPorZona = new int[5];
            double totalPeso = 0;

            // Recorrer el array de envíos y contar los envíos en cada estado y zona
            for (int i = 0;  i < 50;  i++) //Envios
            {
                for (int j = 0; j < 5; j++) //Zonas
                {
                    for (int k = 0; k < 3; k++) //Estados
                    {
                        // Si hay un envío en esa posición, contar y sumar el peso
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

            //Lo de envios por zona y estado, sirve de la manera en que, por cada índice que indica la 
            //zona o el estado en que esta el envío, se va sumando 1 a la cantidad de envíos en esa zona o estado.
            //En total, si hay 50 envíos, se sumarán 50 a la cantidad de envíos en total.
            //Si hay 10 envíos en la zona norte, se sumarán 10 a la cantidad de envíos en la zona norte.


            double pesoPromedio = (totalEnvios > 0) ? totalPeso / totalEnvios : 0;

            // Crear el texto del reporte
            //Se le suma en total todas las variables que se han ido sumando en el ciclo for.
            //Chat dice que es buena manera de ponerlo así xd.
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
