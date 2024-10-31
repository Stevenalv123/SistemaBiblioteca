using SistemaBiblioteca.Forms;

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

        
    }
}
