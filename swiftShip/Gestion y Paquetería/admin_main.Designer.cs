namespace Gestion_y_Paquetería
{
    partial class admin_main
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
            btnIngresoDatos = new Button();
            btnHistorialEnvios = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIngresoDatos
            // 
            btnIngresoDatos.Location = new Point(201, 275);
            btnIngresoDatos.Name = "btnIngresoDatos";
            btnIngresoDatos.Size = new Size(249, 23);
            btnIngresoDatos.TabIndex = 0;
            btnIngresoDatos.Text = "Ingresar envíos ";
            btnIngresoDatos.UseVisualStyleBackColor = true;
            btnIngresoDatos.Click += btnIngresoDatos_Click;
            // 
            // btnHistorialEnvios
            // 
            btnHistorialEnvios.Location = new Point(203, 349);
            btnHistorialEnvios.Name = "btnHistorialEnvios";
            btnHistorialEnvios.Size = new Size(247, 23);
            btnHistorialEnvios.TabIndex = 2;
            btnHistorialEnvios.Text = "Historial de envíos";
            btnHistorialEnvios.UseVisualStyleBackColor = true;
            btnHistorialEnvios.Click += btnHistorialEnvios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 151);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // admin_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnHistorialEnvios);
            Controls.Add(btnIngresoDatos);
            Name = "admin_main";
            Text = "Administrador";
            Load += admin_main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresoDatos;
        private Button btnHistorialEnvios;
        private Label label1;
    }
}