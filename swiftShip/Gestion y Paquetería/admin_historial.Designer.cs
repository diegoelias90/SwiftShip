namespace Gestion_y_Paquetería
{
    partial class admin_historial
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
            dgvHistorial = new DataGridView();
            btnMostrarHistorial = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(33, 40);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(447, 150);
            dgvHistorial.TabIndex = 0;
            // 
            // btnMostrarHistorial
            // 
            btnMostrarHistorial.Location = new Point(141, 336);
            btnMostrarHistorial.Name = "btnMostrarHistorial";
            btnMostrarHistorial.Size = new Size(433, 23);
            btnMostrarHistorial.TabIndex = 1;
            btnMostrarHistorial.Text = "btnMostrarHistorial";
            btnMostrarHistorial.UseVisualStyleBackColor = true;
            btnMostrarHistorial.Click += btnMostrarHistorial_Click;
            // 
            // admin_historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarHistorial);
            Controls.Add(dgvHistorial);
            Name = "admin_historial";
            Text = "admin_historial";
            Load += admin_historial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorial;
        private Button btnMostrarHistorial;
    }
}