namespace Gestion_y_Paquetería
{
    partial class repartidor_vista
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
            dgvEnviosRepartidor = new DataGridView();
            cbNuevoEstado = new ComboBox();
            btnModificarEstado = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEnviosRepartidor).BeginInit();
            SuspendLayout();
            // 
            // dgvEnviosRepartidor
            // 
            dgvEnviosRepartidor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnviosRepartidor.Location = new Point(59, 30);
            dgvEnviosRepartidor.Name = "dgvEnviosRepartidor";
            dgvEnviosRepartidor.Size = new Size(437, 243);
            dgvEnviosRepartidor.TabIndex = 0;
            // 
            // cbNuevoEstado
            // 
            cbNuevoEstado.FormattingEnabled = true;
            cbNuevoEstado.Location = new Point(576, 104);
            cbNuevoEstado.Name = "cbNuevoEstado";
            cbNuevoEstado.Size = new Size(121, 23);
            cbNuevoEstado.TabIndex = 1;
            // 
            // btnModificarEstado
            // 
            btnModificarEstado.Location = new Point(574, 219);
            btnModificarEstado.Name = "btnModificarEstado";
            btnModificarEstado.Size = new Size(202, 23);
            btnModificarEstado.TabIndex = 2;
            btnModificarEstado.Text = "modiicar";
            btnModificarEstado.UseVisualStyleBackColor = true;
            btnModificarEstado.Click += btnModificarEstado_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(558, 268);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(218, 23);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // repartidor_vista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(btnModificarEstado);
            Controls.Add(cbNuevoEstado);
            Controls.Add(dgvEnviosRepartidor);
            Name = "repartidor_vista";
            Text = "empleado_vista";
            Load += repartidor_vista_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEnviosRepartidor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEnviosRepartidor;
        private ComboBox cbNuevoEstado;
        private Button btnModificarEstado;
        private Button btnRegresar;
    }
}