using SistemaBiblioteca.Entities;
using SistemaBiblioteca.Forms.BooksForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.Forms.Books
{
    public partial class AddBooks : Form
    {
        public List<Author> authors { get; set; }
        public List<Editorial> editorials { get; set; }
        public AddBooks()
        {
            InitializeComponent();
            authors = new List<Author>();
            editorials = new List<Editorial>();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.SelectionStart = 0;
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAutorForm addAutorForm = new AddAutorForm(authors); // Pasar la lista existente
            if (addAutorForm.ShowDialog() == DialogResult.OK)
            {
                // Actualizar el ComboBox con la lista de autores actualizada
                CmbAuthors.DataSource = null;
                CmbAuthors.DataSource = authors;
                CmbAuthors.DisplayMember = "Name";
            }
        }

        private void BtnAddEditorial_Click(object sender, EventArgs e)
        {
            AddEditorialForm addEditorialForm = new AddEditorialForm(editorials);
            if(addEditorialForm.ShowDialog()==DialogResult.OK)
            {
                // Actualizar el ComboBox con la lista de editoriales actualizada
                CmbEditorial.DataSource = null;
                CmbEditorial.DataSource = editorials;
                CmbEditorial.DisplayMember = "Name";
            }
        }
    }
}
