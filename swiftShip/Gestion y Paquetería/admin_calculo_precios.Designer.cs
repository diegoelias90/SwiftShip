namespace Gestion_y_Paquetería
{
    partial class admin_calculo_precios
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
            dgvDatos = new DataGridView();
            lbDatosPrecio = new ListBox();
            lblTotalPrecios = new Label();
            btnCalcular = new Button();
            btnGenerarReporte = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(32, 30);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(366, 150);
            dgvDatos.TabIndex = 0;
            // 
            // lbDatosPrecio
            // 
            lbDatosPrecio.FormattingEnabled = true;
            lbDatosPrecio.Location = new Point(450, 32);
            lbDatosPrecio.Name = "lbDatosPrecio";
            lbDatosPrecio.Size = new Size(338, 244);
            lbDatosPrecio.TabIndex = 1;
            // 
            // lblTotalPrecios
            // 
            lblTotalPrecios.AutoSize = true;
            lblTotalPrecios.Location = new Point(502, 295);
            lblTotalPrecios.Name = "lblTotalPrecios";
            lblTotalPrecios.Size = new Size(81, 15);
            lblTotalPrecios.TabIndex = 2;
            lblTotalPrecios.Text = "lbTotalPrecios";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(95, 355);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "btnCalcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new Point(232, 357);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(253, 23);
            btnGenerarReporte.TabIndex = 4;
            btnGenerarReporte.Text = "generar consulta";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // calculo_precios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerarReporte);
            Controls.Add(btnCalcular);
            Controls.Add(lblTotalPrecios);
            Controls.Add(lbDatosPrecio);
            Controls.Add(dgvDatos);
            Name = "calculo_precios";
            Text = "calculo_precios";
            Load += calculo_precios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private ListBox lbDatosPrecio;
        private Label lblTotalPrecios;
        private Button btnCalcular;
        private Button btnGenerarReporte;
    }
}