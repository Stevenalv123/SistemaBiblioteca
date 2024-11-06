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
        public AddBooks()
        {
            InitializeComponent();
            List<string> usStates = new List<string>();
            usStates.Add("Alaska");
            usStates.Add("Arizona");
            usStates.Add("Arkansas");
            usStates.Add("California");
            usStates.Add("Colorado");
            usStates.Add("Connecticut");
            usStates.Add("Delaware");
            usStates.Add("Florida");
            usStates.Add("Georgia");
            sfComboBox1.DataSource = usStates;

        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void maskedTextBox2_Enter(object sender, EventArgs e)
        {
            maskedTextBox2.SelectionStart = 0;
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.SelectionStart = 0;
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox2.SelectionStart = 0;
        }

        private void maskedTextBox3_Enter(object sender, EventArgs e)
        {
            maskedTextBox2.SelectionStart = 0;
        }
    }
}
