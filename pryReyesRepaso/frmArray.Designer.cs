namespace pryReyesRepaso
{
    partial class frmArray
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
            cbogrupo = new ComboBox();
            lblgrupo = new Label();
            lstresultado = new ListBox();
            SuspendLayout();
            // 
            // cbogrupo
            // 
            cbogrupo.FormattingEnabled = true;
            cbogrupo.Location = new Point(76, 22);
            cbogrupo.Name = "cbogrupo";
            cbogrupo.Size = new Size(121, 23);
            cbogrupo.TabIndex = 0;
            cbogrupo.SelectedIndexChanged += cbogrupo_SelectedIndexChanged;
            // 
            // lblgrupo
            // 
            lblgrupo.AutoSize = true;
            lblgrupo.Location = new Point(19, 27);
            lblgrupo.Name = "lblgrupo";
            lblgrupo.Size = new Size(43, 15);
            lblgrupo.TabIndex = 1;
            lblgrupo.Text = "Grupo:";
            // 
            // lstresultado
            // 
            lstresultado.FormattingEnabled = true;
            lstresultado.Location = new Point(19, 79);
            lstresultado.Name = "lstresultado";
            lstresultado.Size = new Size(237, 94);
            lstresultado.TabIndex = 2;
            // 
            // frmArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 201);
            Controls.Add(lstresultado);
            Controls.Add(lblgrupo);
            Controls.Add(cbogrupo);
            Name = "frmArray";
            Text = "frmArray";
            Load += frmArray_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbogrupo;
        private Label lblgrupo;
        private ListBox lstresultado;
    }
}