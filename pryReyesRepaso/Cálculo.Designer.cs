namespace pryReyesRepaso
{
    partial class Cálculo
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
            lblmonto = new Label();
            lbliva = new Label();
            txtmonto = new TextBox();
            cboiva = new ComboBox();
            btncalculo = new Button();
            SuspendLayout();
            // 
            // lblmonto
            // 
            lblmonto.AutoSize = true;
            lblmonto.Location = new Point(25, 20);
            lblmonto.Name = "lblmonto";
            lblmonto.Size = new Size(46, 15);
            lblmonto.TabIndex = 0;
            lblmonto.Text = "Monto:";
            // 
            // lbliva
            // 
            lbliva.AutoSize = true;
            lbliva.Location = new Point(34, 51);
            lbliva.Name = "lbliva";
            lbliva.Size = new Size(27, 15);
            lbliva.TabIndex = 1;
            lbliva.Text = "IVA:";
            // 
            // txtmonto
            // 
            txtmonto.Location = new Point(77, 12);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(100, 23);
            txtmonto.TabIndex = 2;
            // 
            // cboiva
            // 
            cboiva.DropDownStyle = ComboBoxStyle.DropDownList;
            cboiva.FormattingEnabled = true;
            cboiva.Items.AddRange(new object[] { "10%", "20%" });
            cboiva.Location = new Point(77, 43);
            cboiva.Name = "cboiva";
            cboiva.Size = new Size(121, 23);
            cboiva.TabIndex = 3;
            // 
            // btncalculo
            // 
            btncalculo.Location = new Point(90, 83);
            btncalculo.Name = "btncalculo";
            btncalculo.Size = new Size(75, 23);
            btncalculo.TabIndex = 4;
            btncalculo.Text = "Cálculo";
            btncalculo.UseVisualStyleBackColor = true;
            btncalculo.Click += this.btncalculo_Click_1;
            // 
            // Cálculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 248);
            Controls.Add(btncalculo);
            Controls.Add(cboiva);
            Controls.Add(txtmonto);
            Controls.Add(lbliva);
            Controls.Add(lblmonto);
            Name = "Cálculo";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmonto;
        private Label lbliva;
        private TextBox txtmonto;
        private ComboBox cboiva;
        private Button btncalculo;
    }
}