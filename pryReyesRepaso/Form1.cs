namespace pryReyesRepaso
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string codigo;

            codigo = Código.Text;

            string nombre;
            nombre = Nombre.Text;

            MessageBox.Show("Código: "+ codigo +"  Nombre: "+ nombre);
        }
    }

}
