namespace SistemaBiblioteca.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }

        private bool ValidateFields()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(TxtUserName.Text))
            {
                LblErrorPassword.Visible = false;
                LblErrorUserName.Text = "Porfavor, rellene este campo.";
                LblErrorUserName.Visible = true;
                isValid = false;
            }
            else
            {
                LblErrorUserName.Visible = false;
            }
            
            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                LblErrorUserName.Visible = false;
                LblErrorPassword.Text = "Porfavor, rellene este campo.";
                LblErrorPassword.Visible = true;
                isValid = false;
            }
            else
            {
                LblErrorPassword.Visible = false;
            }
            return isValid;
        }
    }
}
