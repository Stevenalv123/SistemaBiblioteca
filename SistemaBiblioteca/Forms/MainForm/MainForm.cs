using SistemaBiblioteca.Forms;
using System.Security.Cryptography.X509Certificates;

namespace SistemaBiblioteca
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Login login = new Login();
            login.Close();
        }

        private void BtnDevolutions_Click(object sender, EventArgs e)
        {

        }
        //Atajos de teclado
        private void AtajosTeclado(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode  == Keys.S)
            {
                GuardarDatos();
                

            }

            else if (e.Control && e.KeyCode == Keys.L)
            {
                LimpiarDatos();
            } 
            else if(e.Control && e.KeyCode == Keys.Q)
            {
                Close();
            }
            
        }
        public void GuardarDatos()
        {

        }
        public void LimpiarDatos()
        {

        }
    }
}
