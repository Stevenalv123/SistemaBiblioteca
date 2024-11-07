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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            sfComboBox2 = new Syncfusion.WinForms.ListView.SfComboBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)sfComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sfComboBox2).BeginInit();
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
            maskedTextBox1.Enter += maskedTextBox1_Enter;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(185, 27, 33);
            BtnCancel.Cursor = Cursors.Hand;
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
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(40, 68, 131);
            BtnSave.Cursor = Cursors.Hand;
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
            // iconButton1
            // 
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.Font = new Font("Cambria", 9F, FontStyle.Bold);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(582, 63);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(144, 32);
            iconButton1.TabIndex = 15;
            iconButton1.Text = "Agregar Autor";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // sfComboBox1
            // 
            sfComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            sfComboBox1.ComboBoxMode = Syncfusion.WinForms.ListView.Enums.ComboBoxMode.MultiSelection;
            sfComboBox1.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            sfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            sfComboBox1.Location = new Point(261, 63);
            sfComboBox1.Name = "sfComboBox1";
            sfComboBox1.Size = new Size(305, 32);
            sfComboBox1.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            sfComboBox1.TabIndex = 16;
            // 
            // sfComboBox2
            // 
            sfComboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            sfComboBox2.ComboBoxMode = Syncfusion.WinForms.ListView.Enums.ComboBoxMode.MultiSelection;
            sfComboBox2.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            sfComboBox2.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            sfComboBox2.Location = new Point(261, 170);
            sfComboBox2.Name = "sfComboBox2";
            sfComboBox2.Size = new Size(305, 32);
            sfComboBox2.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            sfComboBox2.TabIndex = 18;
            // 
            // iconButton2
            // 
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.Font = new Font("Cambria", 9F, FontStyle.Bold);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton2.IconColor = Color.Green;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(582, 170);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(144, 32);
            iconButton2.TabIndex = 17;
            iconButton2.Text = "Agregar Editorial";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = true;
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
            maskedTextBox2.Enter += maskedTextBox2_Enter;
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
            maskedTextBox3.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            maskedTextBox3.Enter += maskedTextBox3_Enter;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(748, 388);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(sfComboBox2);
            Controls.Add(iconButton2);
            Controls.Add(sfComboBox1);
            Controls.Add(iconButton1);
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
            ((System.ComponentModel.ISupportInitialize)sfComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sfComboBox2).EndInit();
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
        private FontAwesome.Sharp.IconButton iconButton1;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
    }
}