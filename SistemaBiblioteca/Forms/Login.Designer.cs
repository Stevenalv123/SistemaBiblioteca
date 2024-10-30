namespace SistemaBiblioteca.Forms
{
    partial class Login
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
            IconoPanel = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            MainPanel = new Panel();
            LblErrorPassword = new Label();
            LblErrorUserName = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            BtnHelp = new FontAwesome.Sharp.IconButton();
            BtnCancel = new Button();
            BtnAccept = new Button();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            TxtUserName = new TextBox();
            TxtPassword = new TextBox();
            IconoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // IconoPanel
            // 
            IconoPanel.Controls.Add(pictureBox1);
            IconoPanel.Dock = DockStyle.Top;
            IconoPanel.Location = new Point(0, 0);
            IconoPanel.Name = "IconoPanel";
            IconoPanel.Size = new Size(455, 161);
            IconoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.PuertaAMilMundosLogo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label1.Location = new Point(66, 3);
            label1.Name = "label1";
            label1.Size = new Size(323, 37);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido de Nuevo";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(LblErrorPassword);
            MainPanel.Controls.Add(LblErrorUserName);
            MainPanel.Controls.Add(panel2);
            MainPanel.Controls.Add(panel1);
            MainPanel.Controls.Add(BtnHelp);
            MainPanel.Controls.Add(BtnCancel);
            MainPanel.Controls.Add(BtnAccept);
            MainPanel.Controls.Add(iconPictureBox2);
            MainPanel.Controls.Add(iconPictureBox1);
            MainPanel.Controls.Add(TxtUserName);
            MainPanel.Controls.Add(TxtPassword);
            MainPanel.Controls.Add(label1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 161);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(455, 291);
            MainPanel.TabIndex = 1;
            // 
            // LblErrorPassword
            // 
            LblErrorPassword.AutoSize = true;
            LblErrorPassword.ForeColor = Color.Red;
            LblErrorPassword.Location = new Point(70, 173);
            LblErrorPassword.Name = "LblErrorPassword";
            LblErrorPassword.Size = new Size(39, 14);
            LblErrorPassword.TabIndex = 10;
            LblErrorPassword.Text = "label2";
            LblErrorPassword.Visible = false;
            // 
            // LblErrorUserName
            // 
            LblErrorUserName.AutoSize = true;
            LblErrorUserName.ForeColor = Color.Red;
            LblErrorUserName.Location = new Point(66, 91);
            LblErrorUserName.Name = "LblErrorUserName";
            LblErrorUserName.Size = new Size(39, 14);
            LblErrorUserName.TabIndex = 9;
            LblErrorUserName.Text = "label2";
            LblErrorUserName.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(70, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 1);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(68, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 1);
            panel1.TabIndex = 7;
            // 
            // BtnHelp
            // 
            BtnHelp.FlatAppearance.BorderSize = 0;
            BtnHelp.FlatStyle = FlatStyle.Flat;
            BtnHelp.Font = new Font("Cambria", 14F, FontStyle.Bold);
            BtnHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            BtnHelp.IconColor = Color.Black;
            BtnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnHelp.IconSize = 36;
            BtnHelp.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHelp.Location = new Point(12, 227);
            BtnHelp.Name = "BtnHelp";
            BtnHelp.Size = new Size(89, 40);
            BtnHelp.TabIndex = 6;
            BtnHelp.Text = "Help";
            BtnHelp.TextAlign = ContentAlignment.MiddleRight;
            BtnHelp.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(185, 27, 33);
            BtnCancel.FlatStyle = FlatStyle.Popup;
            BtnCancel.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnCancel.Location = new Point(171, 227);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(133, 40);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnAccept
            // 
            BtnAccept.BackColor = Color.FromArgb(40, 68, 131);
            BtnAccept.FlatStyle = FlatStyle.Popup;
            BtnAccept.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnAccept.Location = new Point(310, 227);
            BtnAccept.Name = "BtnAccept";
            BtnAccept.Size = new Size(133, 40);
            BtnAccept.TabIndex = 5;
            BtnAccept.Text = "Aceptar";
            BtnAccept.UseVisualStyleBackColor = false;
            BtnAccept.Click += BtnAccept_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 50;
            iconPictureBox2.Location = new Point(14, 127);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(50, 50);
            iconPictureBox2.TabIndex = 4;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 50;
            iconPictureBox1.Location = new Point(12, 45);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(50, 50);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // TxtUserName
            // 
            TxtUserName.BorderStyle = BorderStyle.None;
            TxtUserName.Font = new Font("Cambria", 18F);
            TxtUserName.HideSelection = false;
            TxtUserName.Location = new Point(66, 52);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.PlaceholderText = "Nombre de Usuario";
            TxtUserName.Size = new Size(377, 29);
            TxtUserName.TabIndex = 3;
            // 
            // TxtPassword
            // 
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Font = new Font("Cambria", 18F);
            TxtPassword.HideSelection = false;
            TxtPassword.Location = new Point(68, 134);
            TxtPassword.MaxLength = 12;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '•';
            TxtPassword.PlaceholderText = "Contraseña";
            TxtPassword.Size = new Size(377, 29);
            TxtPassword.TabIndex = 3;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(455, 452);
            Controls.Add(MainPanel);
            Controls.Add(IconoPanel);
            Font = new Font("Cambria", 9F);
            MaximizeBox = false;
            MaximumSize = new Size(471, 491);
            MinimizeBox = false;
            MinimumSize = new Size(471, 491);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesion";
            TopMost = true;
            IconoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel IconoPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel MainPanel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox TxtUserName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TextBox TxtPassword;
        private Button BtnCancel;
        private Button BtnAccept;
        private FontAwesome.Sharp.IconButton BtnHelp;
        private Panel panel1;
        private Panel panel2;
        private Label LblErrorUserName;
        private Label LblErrorPassword;
    }
}