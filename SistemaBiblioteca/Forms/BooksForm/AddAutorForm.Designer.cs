namespace SistemaBiblioteca.Forms.BooksForm
{
    partial class AddAutorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(190, 26);
            label1.TabIndex = 0;
            label1.Text = "Nombre del autor: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 55);
            label2.Name = "label2";
            label2.Size = new Size(147, 26);
            label2.TabIndex = 0;
            label2.Text = "Nacionalidad: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 97);
            label3.Name = "label3";
            label3.Size = new Size(199, 26);
            label3.TabIndex = 0;
            label3.Text = "Año de nacimiento: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 33);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 33);
            textBox2.TabIndex = 1;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.White;
            maskedTextBox2.BeepOnError = true;
            maskedTextBox2.Font = new Font("Cambria", 15.75F);
            maskedTextBox2.HidePromptOnLeave = true;
            maskedTextBox2.Location = new Point(203, 94);
            maskedTextBox2.Mask = "0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.PromptChar = ' ';
            maskedTextBox2.RejectInputOnFirstFailure = true;
            maskedTextBox2.Size = new Size(279, 32);
            maskedTextBox2.SkipLiterals = false;
            maskedTextBox2.TabIndex = 20;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(185, 27, 33);
            BtnCancel.Cursor = Cursors.Hand;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Location = new Point(504, 57);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(133, 40);
            BtnCancel.TabIndex = 21;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(40, 68, 131);
            BtnSave.Cursor = Cursors.Hand;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(504, 11);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(133, 40);
            BtnSave.TabIndex = 22;
            BtnSave.Text = "Guardar";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // AddAutorForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = BtnCancel;
            ClientSize = new Size(650, 151);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(maskedTextBox2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 16F);
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(666, 190);
            MinimizeBox = false;
            MinimumSize = new Size(666, 190);
            Name = "AddAutorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Autor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox2;
        private Button BtnCancel;
        private Button BtnSave;
    }
}