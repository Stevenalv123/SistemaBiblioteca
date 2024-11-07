using SistemaBiblioteca.Forms.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.Forms
{
    public partial class MainFormBooks : Form
    {
        public MainFormBooks()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDialogBooks.ShowDialog();
        }

        private void AddNewBook(object sender, EventArgs e)
        {
            AddBooks addBooks = new AddBooks();
            addBooks.ShowDialog();
            if (addBooks.DialogResult == DialogResult.OK)
            {
                ShowAlert();
            }
        }

        private async void ShowAlert()
        {
            AlertForm alert = new AlertForm();
            alert.Show();
            await Task.Delay(3000);
            alert.Close();
        }
    }
}
