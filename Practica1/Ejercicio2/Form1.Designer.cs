namespace Ejercicio2
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
            btnCambiar = new Button();
            lblTexto = new Label();
            SuspendLayout();
            // 
            // btnCambiar
            // 
            btnCambiar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambiar.Location = new Point(509, 12);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(305, 113);
            btnCambiar.TabIndex = 0;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI Black", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(162, 139);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(830, 89);
            lblTexto.TabIndex = 1;
            lblTexto.Text = "ESTO ES UNA MENSAJE.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1631, 240);
            Controls.Add(lblTexto);
            Controls.Add(btnCambiar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCambiar;
        private Label lblTexto;
    }
}
