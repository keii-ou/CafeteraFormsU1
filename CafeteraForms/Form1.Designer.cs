namespace CafeteraForms
{
    partial class Form1
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
            lblEstado = new Label();
            lblCantidad = new Label();
            progressCafe = new ProgressBar();
            btnEncender = new Button();
            btnServir = new Button();
            btnRellenar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(127, 9);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(129, 20);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Estado: APAGADA";
            lblEstado.Click += label1_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(75, 54);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(44, 20);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Tazas";
            lblCantidad.Click += lblCantidad_Click;
            // 
            // progressCafe
            // 
            progressCafe.Location = new Point(86, 77);
            progressCafe.Name = "progressCafe";
            progressCafe.Size = new Size(207, 29);
            progressCafe.TabIndex = 2;
            progressCafe.Click += progressCafe_Click;
            // 
            // btnEncender
            // 
            btnEncender.Location = new Point(86, 131);
            btnEncender.Name = "btnEncender";
            btnEncender.Size = new Size(207, 29);
            btnEncender.TabIndex = 3;
            btnEncender.Text = "Encender/Apagar";
            btnEncender.UseVisualStyleBackColor = true;
            btnEncender.Click += btnEncender_Click;
            // 
            // btnServir
            // 
            btnServir.Location = new Point(86, 166);
            btnServir.Name = "btnServir";
            btnServir.Size = new Size(94, 29);
            btnServir.TabIndex = 4;
            btnServir.Text = "Servir";
            btnServir.UseVisualStyleBackColor = true;
            btnServir.Click += btnServir_Click;
            // 
            // btnRellenar
            // 
            btnRellenar.Location = new Point(199, 166);
            btnRellenar.Name = "btnRellenar";
            btnRellenar.Size = new Size(94, 29);
            btnRellenar.TabIndex = 5;
            btnRellenar.Text = "Rellenar";
            btnRellenar.UseVisualStyleBackColor = true;
            btnRellenar.Click += btnRellenar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 242);
            Controls.Add(btnRellenar);
            Controls.Add(btnServir);
            Controls.Add(btnEncender);
            Controls.Add(progressCafe);
            Controls.Add(lblCantidad);
            Controls.Add(lblEstado);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstado;
        private Label lblCantidad;
        private ProgressBar progressCafe;
        private Button btnEncender;
        private Button btnServir;
        private Button btnRellenar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
