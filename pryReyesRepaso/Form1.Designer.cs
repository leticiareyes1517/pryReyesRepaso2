namespace pryReyesRepaso
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
            lblCódigo = new Label();
            Código = new TextBox();
            btnRegistrar = new Button();
            lblNombre = new Label();
            Nombre = new TextBox();
            SuspendLayout();
            // 
            // lblCódigo
            // 
            lblCódigo.AutoSize = true;
            lblCódigo.Location = new Point(18, 29);
            lblCódigo.Name = "lblCódigo";
            lblCódigo.Size = new Size(46, 15);
            lblCódigo.TabIndex = 0;
            lblCódigo.Text = "Código";
            // 
            // Código
            // 
            Código.Location = new Point(70, 26);
            Código.Name = "Código";
            Código.Size = new Size(100, 23);
            Código.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(140, 120);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // Nombre
            // 
            Nombre.Location = new Point(70, 63);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(100, 23);
            Nombre.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 194);
            Controls.Add(Nombre);
            Controls.Add(lblNombre);
            Controls.Add(btnRegistrar);
            Controls.Add(Código);
            Controls.Add(lblCódigo);
            Name = "Form1";
            Text = "Carga de Datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCódigo;
        private TextBox Código;
        private Button button1;
        private Button btnRegistrar;
        private Label lblNombre;
        private TextBox Nombre;
    }
}
