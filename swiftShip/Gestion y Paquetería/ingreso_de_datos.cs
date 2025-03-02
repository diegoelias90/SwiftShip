using Gestion_y_Paquetería;

namespace Gestion_y_Paquetería
{
    public partial class ingreso_de_datos : Form
    {
        // Array tridimensional para almacenar los envíos: 50 envíos, 5 zonas y 3 estados.
        private Envio[,,] envios = new Envio[50, 5, 3];
        // Contador que lleva la cantidad de envíos almacenados.
        private int contadorEnvios = 0;
        // Zonas predefinidas.
        private string[] zonas = { "Zona Norte", "Zona Sur", "Zona Este", "Zona Oeste", "Zona Central" };
        // Estados posibles para un envío.
        private string[] estados = { "Pendiente", "En tránsito", "Entregado" };

        // Constructor: Inicializa componentes y carga datos iniciales.
        public ingreso_de_datos()
        {
            InitializeComponent();
            CargarZonas();
            CargarEstados();
            CargarDatosQuemados();
            ActualizarListaEnvios();
        }

        // Configura los ComboBox para que solo permitan seleccionar elementos.
        private void ingreso_de_datos_Load(object sender, EventArgs e)
        {
            cbZona.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Carga las zonas en el ComboBox.
        private void CargarZonas()
        {
            cbZona.Items.AddRange(zonas);
            cbZona.SelectedIndex = 0;
        }

        // Carga los estados en el ComboBox.
        private void CargarEstados()
        {
            cbEstado.Items.AddRange(estados);
            cbEstado.SelectedIndex = 0; // "Pendiente" por defecto.
        }

        // Carga envíos predefinidos (datos quemados) para mostrar al inicio.
        private void CargarDatosQuemados()
        {
            AgregarEnvio("Juan Pérez", "Calle 123, Ciudad", 2.5, 0, 0); // Zona Norte, Pendiente
            AgregarEnvio("María López", "Av. Principal, Zona Sur", 1.8, 1, 1); // Zona Sur, En tránsito
            AgregarEnvio("Carlos Mendoza", "Calle Secundaria, Zona Este", 3.2, 2, 2); // Zona Este, Entregado
        }

        private void ActualizarListaEnvios()
        {
            List<Envio> listaTemporal = new List<Envio>();

            for (int i = 0; i < contadorEnvios; i++)
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

            // Actualiza el DataGridView para mostrar los envíos almacenados.
            dgvEnvios.DataSource = null;
            dgvEnvios.DataSource = listaTemporal;
        }

        // Evento que se ejecuta al hacer clic en el botón para agregar un envío.
        private void btAgregarEnvio_Click(object sender, EventArgs e)
        {
            // Se validan los datos ingresados.
            if (string.IsNullOrWhiteSpace(txtDestinatario.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                !double.TryParse(txtPeso.Text, out double peso) || peso <= 0 ||
                cbZona.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese todos los datos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agrega el envío con los datos proporcionados.
            AgregarEnvio(txtDestinatario.Text, txtDireccion.Text, peso, cbZona.SelectedIndex, cbEstado.SelectedIndex);
            // Limpia los campos después de agregar el envío.
            txtDestinatario.Clear();
            txtDireccion.Clear();
            txtPeso.Clear();
        }

        // Método para agregar un envío al array.
        private void AgregarEnvio(string destinatario, string direccion, double peso, int zonaIndex, int estadoIndex)
        {
            // Se verifica que no se supere el límite de 50 envíos.
            if (contadorEnvios >= 50)
            {
                MessageBox.Show("Se ha alcanzado el límite de envíos almacenados.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se genera un código único para el envío.
            string codigoSeguimiento = GenerarCodigoSeguimiento();

            //Aquí se está instanciando el nuevo objeto de la clase envio para agregarlo
            Envio nuevoEnvio = new Envio
            {
                CodigoSeguimiento = codigoSeguimiento,
                Destinatario = destinatario,
                Direccion = direccion,
                Peso = peso,
                Zona = zonas[zonaIndex],
                Estado = estados[estadoIndex],
                FechaRegistro = DateTime.Now
            };

            // Almacena el envío en la posición correspondiente del array.
            envios[contadorEnvios, zonaIndex, estadoIndex] = nuevoEnvio;
            contadorEnvios++;

            // Actualiza el DataGridView para reflejar el nuevo envío.
            ActualizarListaEnvios();
        }

        // Funcion para generar un código de seguimiento único para cada envío.
        private string GenerarCodigoSeguimiento()
        {
            string codigo;
            Random random = new Random();

            do
            {
                codigo = "ENV-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + random.Next(1000, 9999);
            } while (CodigoExiste(codigo));

            return codigo;
        }

        // Verifica si el código de seguimiento ya existe en el array.
        private bool CodigoExiste(string codigo)
        {
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (envios[i, j, k] != null && envios[i, j, k].CodigoSeguimiento == codigo)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private void btnCalcularPrecios_Click(object sender, EventArgs e)
        {
            calculo_precios calculo_precios = new calculo_precios(envios);
            calculo_precios.ShowDialog();

        }
    }
}