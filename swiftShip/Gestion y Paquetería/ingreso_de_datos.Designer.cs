namespace Gestion_y_Paquetería
{
    partial class ingreso_de_datos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDestinatario = new Label();
            txtDestinatario = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblPeso = new Label();
            txtPeso = new TextBox();
            lblZona = new Label();
            cbZona = new ComboBox();
            btAgregarEnvio = new Button();
            btActualizarEstado = new Button();
            lblListaEnvios = new Label();
            groupBox1 = new GroupBox();
            cbEstado = new ComboBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            dgvEnvios = new DataGridView();
            btnCalcularPrecios = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnvios).BeginInit();
            SuspendLayout();
            // 
            // lblDestinatario
            // 
            lblDestinatario.AutoSize = true;
            lblDestinatario.Location = new Point(21, 29);
            lblDestinatario.Name = "lblDestinatario";
            lblDestinatario.Size = new Size(83, 15);
            lblDestinatario.TabIndex = 0;
            lblDestinatario.Text = "lblDestinatario";
            // 
            // txtDestinatario
            // 
            txtDestinatario.Location = new Point(21, 67);
            txtDestinatario.Name = "txtDestinatario";
            txtDestinatario.Size = new Size(100, 23);
            txtDestinatario.TabIndex = 1;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(157, 29);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(70, 15);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "lblDireccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(157, 67);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 3;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(293, 29);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(45, 15);
            lblPeso.TabIndex = 4;
            lblPeso.Text = "lblPeso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(293, 67);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 5;
            // 
            // lblZona
            // 
            lblZona.AutoSize = true;
            lblZona.Location = new Point(444, 29);
            lblZona.Name = "lblZona";
            lblZona.Size = new Size(47, 15);
            lblZona.TabIndex = 6;
            lblZona.Text = "lblZona";
            // 
            // cbZona
            // 
            cbZona.FormattingEnabled = true;
            cbZona.Location = new Point(444, 67);
            cbZona.Name = "cbZona";
            cbZona.Size = new Size(121, 23);
            cbZona.TabIndex = 7;
            // 
            // btAgregarEnvio
            // 
            btAgregarEnvio.Location = new Point(22, 52);
            btAgregarEnvio.Name = "btAgregarEnvio";
            btAgregarEnvio.Size = new Size(75, 23);
            btAgregarEnvio.TabIndex = 10;
            btAgregarEnvio.Text = "Agregar";
            btAgregarEnvio.UseVisualStyleBackColor = true;
            btAgregarEnvio.Click += btAgregarEnvio_Click;
            // 
            // btActualizarEstado
            // 
            btActualizarEstado.Location = new Point(156, 52);
            btActualizarEstado.Name = "btActualizarEstado";
            btActualizarEstado.Size = new Size(75, 23);
            btActualizarEstado.TabIndex = 11;
            btActualizarEstado.Text = "Actualizar";
            btActualizarEstado.UseVisualStyleBackColor = true;
            // 
            // lblListaEnvios
            // 
            lblListaEnvios.AutoSize = true;
            lblListaEnvios.Location = new Point(21, 34);
            lblListaEnvios.Name = "lblListaEnvios";
            lblListaEnvios.Size = new Size(78, 15);
            lblListaEnvios.TabIndex = 12;
            lblListaEnvios.Text = "lblListaEnvios";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbEstado);
            groupBox1.Controls.Add(lblDestinatario);
            groupBox1.Controls.Add(txtDestinatario);
            groupBox1.Controls.Add(lblDireccion);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(lblPeso);
            groupBox1.Controls.Add(txtPeso);
            groupBox1.Controls.Add(cbZona);
            groupBox1.Controls.Add(lblZona);
            groupBox1.Location = new Point(31, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 157);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(26, 114);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(121, 23);
            cbEstado.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btAgregarEnvio);
            groupBox3.Controls.Add(btActualizarEstado);
            groupBox3.Location = new Point(31, 194);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(267, 119);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvEnvios);
            groupBox4.Controls.Add(lblListaEnvios);
            groupBox4.Location = new Point(618, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(477, 282);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // dgvEnvios
            // 
            dgvEnvios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnvios.Location = new Point(21, 69);
            dgvEnvios.Name = "dgvEnvios";
            dgvEnvios.Size = new Size(450, 207);
            dgvEnvios.TabIndex = 13;
            // 
            // btnCalcularPrecios
            // 
            btnCalcularPrecios.Location = new Point(52, 348);
            btnCalcularPrecios.Name = "btnCalcularPrecios";
            btnCalcularPrecios.Size = new Size(75, 23);
            btnCalcularPrecios.TabIndex = 17;
            btnCalcularPrecios.Text = "calcular precios";
            btnCalcularPrecios.UseVisualStyleBackColor = true;
            btnCalcularPrecios.Click += btnCalcularPrecios_Click;
            // 
            // ingreso_de_datos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 444);
            Controls.Add(btnCalcularPrecios);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "ingreso_de_datos";
            Text = "Form1";
            Load += ingreso_de_datos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnvios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDestinatario;
        private TextBox txtDestinatario;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblPeso;
        private TextBox txtPeso;
        private Label lblZona;
        private ComboBox cbZona;
        private Button btAgregarEnvio;
        private Button btActualizarEstado;
        private Label lblListaEnvios;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dgvEnvios;
        private Button btnCalcularPrecios;
        private ComboBox cbEstado;
    }
}
