using SistemaBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.Forms.BooksForm
{
    public partial class AddCategorieForm : Form
    {
        private Queue<Categorie> categories;
        public AddCategorieForm(Queue<Categorie> existingCategories)
        {
            InitializeComponent();
            categories = existingCategories;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("El campo nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                categories.Enqueue(new Categorie(name));
                MessageBox.Show("Categoria agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
