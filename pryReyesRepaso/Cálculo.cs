using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryReyesRepaso
{
    public partial class Cálculo : Form
    {
        public Cálculo()
        {
            InitializeComponent();
        }

        private void btncalculo_Click_1(object sender, EventArgs e)
        {
            // Validar monto
            if (string.IsNullOrWhiteSpace(txtmonto.Text))
            {
                MessageBox.Show("Ingrese un monto.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmonto.Focus();
                return;
            }

            
            if (!decimal.TryParse(txtmonto.Text, out decimal monto))
            {
                MessageBox.Show("El monto debe ser un número válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmonto.Clear();
                txtmonto.Focus();
                return;
            }

            
            if (cboiva.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un porcentaje de IVA.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboiva.Focus();
                return;
            }

            // Mensaje final
            MessageBox.Show(
                "Monto: " + txtmonto.Text + "\nIVA: " + cboiva.Text,
                "Resultado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}


