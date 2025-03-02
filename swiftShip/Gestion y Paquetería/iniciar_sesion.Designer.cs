namespace Gestion_y_Paquetería
{
    partial class iniciar_sesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarSesion = new Button();
            btnRegresar = new Button();
            chkContra = new CheckBox();
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            txtNombreUsuario = new TextBox();
            lblNombreUsuario = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(131, 337);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(204, 23);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(428, 334);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(259, 23);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // chkContra
            // 
            chkContra.AutoSize = true;
            chkContra.Location = new Point(223, 273);
            chkContra.Name = "chkContra";
            chkContra.Size = new Size(82, 19);
            chkContra.TabIndex = 2;
            chkContra.Text = "checkBox1";
            chkContra.UseVisualStyleBackColor = true;
            chkContra.CheckedChanged += chkContra_CheckedChanged;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(155, 243);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(270, 23);
            txtContrasena.TabIndex = 3;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(174, 218);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 4;
            lblContrasena.Text = "Contraseña";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(146, 168);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(322, 23);
            txtNombreUsuario.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(160, 133);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(96, 15);
            lblNombreUsuario.TabIndex = 6;
            lblNombreUsuario.Text = "Nombre usuario:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(313, 69);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(55, 15);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "swiftShip";
            // 
            // iniciar_sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(chkContra);
            Controls.Add(btnRegresar);
            Controls.Add(btnIniciarSesion);
            Name = "iniciar_sesion";
            Text = "Inicio de sesión";
            Load += iniciar_sesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private Button btnRegresar;
        private CheckBox chkContra;
        private TextBox txtContrasena;
        private Label lblContrasena;
        private TextBox txtNombreUsuario;
        private Label lblNombreUsuario;
        private Label lblTitulo;
    }
}