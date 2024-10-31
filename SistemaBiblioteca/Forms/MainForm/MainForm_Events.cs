using SistemaBiblioteca.Forms;
namespace SistemaBiblioteca
{
    public partial class MainForm:Form
    {
        private void ShowUsers(object sender, EventArgs e)
        {
            OpenForm(new Users());
        }

        private void ShowBooks(object sender, EventArgs e)
        {
            OpenForm(new Books());
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Exit exit = new Exit();
            DialogResult result = exit.ShowDialog();
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
