namespace SistemaBiblioteca.Forms.Books
{
    partial class AddBooks
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            label7 = new Label();
            BtnAddAuthor = new FontAwesome.Sharp.IconButton();
            CmbAuthors = new Syncfusion.WinForms.ListView.SfComboBox();
            BtnAddEditorial = new FontAwesome.Sharp.IconButton();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            CmbEditorial = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)CmbAuthors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CmbEditorial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label1.Location = new Point(149, 14);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Titulo: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label2.Location = new Point(153, 65);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 1;
            label2.Text = "Autor: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label3.Location = new Point(164, 120);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 2;
            label3.Text = "ISBN: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label4.Location = new Point(118, 170);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 3;
            label4.Text = "Editorial: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label5.Location = new Point(7, 220);
            label5.Name = "label5";
            label5.Size = new Size(233, 28);
            label5.TabIndex = 4;
            label5.Text = "Año de publicacion: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label6.Location = new Point(81, 269);
            label6.Name = "label6";
            label6.Size = new Size(159, 28);
            label6.TabIndex = 5;
            label6.Text = "Stock Actual: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Cambria", 15.75F);
            textBox1.Location = new Point(261, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 32);
            textBox1.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.White;
            maskedTextBox1.BeepOnError = true;
            maskedTextBox1.Font = new Font("Cambria", 15.75F);
            maskedTextBox1.HidePromptOnLeave = true;
            maskedTextBox1.Location = new Point(261, 118);
            maskedTextBox1.Mask = "000-0-00-000000-0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PromptChar = ' ';
            maskedTextBox1.RejectInputOnFirstFailure = true;
            maskedTextBox1.Size = new Size(200, 32);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.Click += maskedTextBox1_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(185, 27, 33);
            BtnCancel.Cursor = Cursors.Hand;
            BtnCancel.DialogResult = DialogResult.Cancel;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Location = new Point(443, 328);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(133, 40);
            BtnCancel.TabIndex = 12;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(40, 68, 131);
            BtnSave.Cursor = Cursors.Hand;
            BtnSave.DialogResult = DialogResult.OK;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(593, 328);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(133, 40);
            BtnSave.TabIndex = 13;
            BtnSave.Text = "Guardar";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 18F);
            label7.Location = new Point(411, 267);
            label7.Name = "label7";
            label7.Size = new Size(108, 28);
            label7.TabIndex = 14;
            label7.Text = "Unidades";
            // 
            // BtnAddAuthor
            // 
            BtnAddAuthor.Cursor = Cursors.Hand;
            BtnAddAuthor.FlatAppearance.BorderSize = 0;
            BtnAddAuthor.Font = new Font("Cambria", 9F, FontStyle.Bold);
            BtnAddAuthor.IconChar = FontAwesome.Sharp.IconChar.Add;
            BtnAddAuthor.IconColor = Color.Green;
            BtnAddAuthor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnAddAuthor.IconSize = 26;
            BtnAddAuthor.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAddAuthor.Location = new Point(582, 63);
            BtnAddAuthor.Name = "BtnAddAuthor";
            BtnAddAuthor.Size = new Size(129, 32);
            BtnAddAuthor.TabIndex = 15;
            BtnAddAuthor.Text = "Agregar Autor";
            BtnAddAuthor.TextAlign = ContentAlignment.MiddleRight;
            BtnAddAuthor.UseVisualStyleBackColor = true;
            BtnAddAuthor.Click += BtnAddAuthor_Click;
            // 
            // CmbAuthors
            // 
            CmbAuthors.AutoCompleteMode = AutoCompleteMode.Suggest;
            CmbAuthors.BackColor = Color.White;
            CmbAuthors.ComboBoxMode = Syncfusion.WinForms.ListView.Enums.ComboBoxMode.MultiSelection;
            CmbAuthors.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            CmbAuthors.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            CmbAuthors.Location = new Point(261, 63);
            CmbAuthors.Name = "CmbAuthors";
            CmbAuthors.Size = new Size(305, 32);
            CmbAuthors.Style.EditorStyle.BackColor = Color.White;
            CmbAuthors.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            CmbAuthors.TabIndex = 16;
            CmbAuthors.Watermark = "Seleccione uno o mas autores";
            // 
            // BtnAddEditorial
            // 
            BtnAddEditorial.Cursor = Cursors.Hand;
            BtnAddEditorial.FlatAppearance.BorderSize = 0;
            BtnAddEditorial.Font = new Font("Cambria", 8F, FontStyle.Bold);
            BtnAddEditorial.IconChar = FontAwesome.Sharp.IconChar.Add;
            BtnAddEditorial.IconColor = Color.Green;
            BtnAddEditorial.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnAddEditorial.IconSize = 26;
            BtnAddEditorial.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAddEditorial.Location = new Point(582, 170);
            BtnAddEditorial.Name = "BtnAddEditorial";
            BtnAddEditorial.Size = new Size(129, 32);
            BtnAddEditorial.TabIndex = 17;
            BtnAddEditorial.Text = "Agregar Editorial";
            BtnAddEditorial.TextAlign = ContentAlignment.MiddleRight;
            BtnAddEditorial.UseVisualStyleBackColor = true;
            BtnAddEditorial.Click += BtnAddEditorial_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.White;
            maskedTextBox2.BeepOnError = true;
            maskedTextBox2.Font = new Font("Cambria", 15.75F);
            maskedTextBox2.HidePromptOnLeave = true;
            maskedTextBox2.Location = new Point(261, 216);
            maskedTextBox2.Mask = "0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.PromptChar = ' ';
            maskedTextBox2.RejectInputOnFirstFailure = true;
            maskedTextBox2.Size = new Size(144, 32);
            maskedTextBox2.SkipLiterals = false;
            maskedTextBox2.TabIndex = 19;
            maskedTextBox2.Click += maskedTextBox2_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.BackColor = Color.White;
            maskedTextBox3.BeepOnError = true;
            maskedTextBox3.Font = new Font("Cambria", 15.75F);
            maskedTextBox3.HidePromptOnLeave = true;
            maskedTextBox3.Location = new Point(261, 269);
            maskedTextBox3.Mask = "0000000000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.PromptChar = ' ';
            maskedTextBox3.RejectInputOnFirstFailure = true;
            maskedTextBox3.Size = new Size(144, 32);
            maskedTextBox3.SkipLiterals = false;
            maskedTextBox3.TabIndex = 20;
            // 
            // CmbEditorial
            // 
            CmbEditorial.AutoCompleteMode = AutoCompleteMode.Suggest;
            CmbEditorial.BackColor = Color.White;
            CmbEditorial.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            CmbEditorial.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            CmbEditorial.Location = new Point(261, 170);
            CmbEditorial.Name = "CmbEditorial";
            CmbEditorial.Size = new Size(305, 32);
            CmbEditorial.Style.ReadOnlyEditorStyle.BackColor = Color.White;
            CmbEditorial.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            CmbEditorial.TabIndex = 18;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(748, 388);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(CmbEditorial);
            Controls.Add(BtnAddEditorial);
            Controls.Add(CmbAuthors);
            Controls.Add(BtnAddAuthor);
            Controls.Add(label7);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(764, 427);
            MinimizeBox = false;
            MinimumSize = new Size(764, 427);
            Name = "AddBooks";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Libro";
            ((System.ComponentModel.ISupportInitialize)CmbAuthors).EndInit();
            ((System.ComponentModel.ISupportInitialize)CmbEditorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Button BtnCancel;
        private Button BtnSave;
        private Label label7;
        private FontAwesome.Sharp.IconButton BtnAddAuthor;
        private Syncfusion.WinForms.ListView.SfComboBox CmbAuthors;
        private FontAwesome.Sharp.IconButton BtnAddEditorial;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private Syncfusion.WinForms.ListView.SfComboBox CmbEditorial;
    }
}