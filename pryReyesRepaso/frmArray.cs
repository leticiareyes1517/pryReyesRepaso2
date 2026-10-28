using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryReyesRepaso
{
    public partial class frmArray : Form
    {

        //DECLARACION DE VARIABLES GLOBALES
        
        //declarar y crear en memora un array de 1 dimensiòn
        string[] vectorGrupoA = new string[4];
        string[] vectorGrupoB = new string[3];
        string[] vectorGrupoC = new string[3];

        public frmArray()
        {
            InitializeComponent();
        }

        private void cbogrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbogrupo.Text)
            {
                case "Grupo A":
                    lstresultado.Items.Clear();
                    lstresultado.Items.Add("CPU");
                    lstresultado.Items.Add("Micro");
                    lstresultado.Items.Add("Placa");
                    lstresultado.Items.Add("Memoria");
                    break;
                case "Grupo B":
                    lstresultado.Items.Clear();
                    lstresultado.Items.Add("Visual");
                    lstresultado.Items.Add("C#");
                    lstresultado.Items.Add("Desktop");
                    break;
                case "Grupo C":
                    lstresultado.Items.Clear();
                    lstresultado.Items.Add("Server");
                    lstresultado.Items.Add("AWS");
                    lstresultado.Items.Add("Cloud");
                    break;
            }
        }

        private void frmArray_Load(object sender, EventArgs e)
        {
            
            cbogrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            
            cbogrupo.Items.Add("Grupo A");
            cbogrupo.Items.Add("Grupo B");
            cbogrupo.Items.Add("Grupo C");

            //grabar en un lugar del array
            vectorGrupoA[0] = "CPU";
            vectorGrupoA[1] = "Micro";
            vectorGrupoA[2] = "Placa";
            vectorGrupoA[3] = "Memoria";

            vectorGrupoB[0] = "Visual";
            vectorGrupoB[1] = "C#";
            vectorGrupoB[2] = "Desktop";

            vectorGrupoC[0] = "Server";
            vectorGrupoC[1] = "AWS"; 
            vectorGrupoC[2] = "Cloud";
                        

        }
    }
}