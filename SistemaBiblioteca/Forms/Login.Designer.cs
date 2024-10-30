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
            panel2 = new Panel();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            button2 = new Button();
            button1 = new Button();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            TxtContraseña = new TextBox();
            TxtUserName = new TextBox();
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
            MainPanel.Controls.Add(panel2);
            MainPanel.Controls.Add(panel1);
            MainPanel.Controls.Add(iconButton1);
            MainPanel.Controls.Add(button2);
            MainPanel.Controls.Add(button1);
            MainPanel.Controls.Add(iconPictureBox2);
            MainPanel.Controls.Add(iconPictureBox1);
            MainPanel.Controls.Add(TxtContraseña);
            MainPanel.Controls.Add(TxtUserName);
            MainPanel.Controls.Add(label1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 161);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(455, 291);
            MainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(68, 151);
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
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Cambria", 14F, FontStyle.Bold);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Question;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 36;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(12, 227);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(89, 40);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Help";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(185, 27, 33);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Cambria", 10F, FontStyle.Bold);
            button2.Location = new Point(171, 227);
            button2.Name = "button2";
            button2.Size = new Size(133, 40);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 68, 131);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cambria", 10F, FontStyle.Bold);
            button1.Location = new Point(310, 227);
            button1.Name = "button1";
            button1.Size = new Size(133, 40);
            button1.TabIndex = 5;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 50;
            iconPictureBox2.Location = new Point(12, 109);
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
            // TxtContraseña
            // 
            TxtContraseña.BorderStyle = BorderStyle.None;
            TxtContraseña.Font = new Font("Cambria", 18F);
            TxtContraseña.HideSelection = false;
            TxtContraseña.Location = new Point(66, 116);
            TxtContraseña.MaxLength = 12;
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '•';
            TxtContraseña.PlaceholderText = "Contraseña";
            TxtContraseña.Size = new Size(377, 29);
            TxtContraseña.TabIndex = 3;
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
        private TextBox TxtContraseña;
        private Button button2;
        private Button button1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private Panel panel2;
    }
}