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

        //Controla el evento de cambiar el estado del checkbox de mostrar contraseña.
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

        //Controla el evento de hacer clic en el botón de iniciar sesión.
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
                admin_main admin_main = new admin_main();
                this.Hide();
                admin_main.ShowDialog();
                this.Show();
            }
            //Aquí se puede ingresar otro usuario y contraseña para el empleado.
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Botón que me regresa al formulario de inicio.
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
