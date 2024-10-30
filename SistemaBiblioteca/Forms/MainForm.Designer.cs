namespace SistemaBiblioteca
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            LateralPanel = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            BtnUsers = new FontAwesome.Sharp.IconButton();
            BtnBooks = new FontAwesome.Sharp.IconButton();
            IconPanel = new Panel();
            LogoPicture = new PictureBox();
            MainPanel = new Panel();
            LateralPanel.SuspendLayout();
            IconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            SuspendLayout();
            // 
            // LateralPanel
            // 
            LateralPanel.Controls.Add(iconButton1);
            LateralPanel.Controls.Add(iconButton2);
            LateralPanel.Controls.Add(BtnUsers);
            LateralPanel.Controls.Add(BtnBooks);
            LateralPanel.Controls.Add(IconPanel);
            LateralPanel.Dock = DockStyle.Left;
            LateralPanel.Location = new Point(0, 0);
            LateralPanel.Name = "LateralPanel";
            LateralPanel.Size = new Size(358, 630);
            LateralPanel.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 60;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 470);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(358, 73);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "Reportes";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.HandsHolding;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 60;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 397);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(358, 73);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "Prestamos y Devoluciones";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // BtnUsers
            // 
            BtnUsers.Dock = DockStyle.Top;
            BtnUsers.FlatAppearance.BorderSize = 0;
            BtnUsers.FlatStyle = FlatStyle.Popup;
            BtnUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUsers.IconChar = FontAwesome.Sharp.IconChar.User;
            BtnUsers.IconColor = Color.Black;
            BtnUsers.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnUsers.IconSize = 60;
            BtnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            BtnUsers.Location = new Point(0, 324);
            BtnUsers.Name = "BtnUsers";
            BtnUsers.Size = new Size(358, 73);
            BtnUsers.TabIndex = 2;
            BtnUsers.Text = "Usuarios";
            BtnUsers.UseVisualStyleBackColor = true;
            // 
            // BtnBooks
            // 
            BtnBooks.Dock = DockStyle.Top;
            BtnBooks.FlatAppearance.BorderSize = 0;
            BtnBooks.FlatStyle = FlatStyle.Popup;
            BtnBooks.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnBooks.IconColor = Color.Black;
            BtnBooks.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnBooks.IconSize = 60;
            BtnBooks.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBooks.Location = new Point(0, 251);
            BtnBooks.Name = "BtnBooks";
            BtnBooks.Size = new Size(358, 73);
            BtnBooks.TabIndex = 1;
            BtnBooks.Text = "Libros";
            BtnBooks.UseVisualStyleBackColor = true;
            // 
            // IconPanel
            // 
            IconPanel.Controls.Add(LogoPicture);
            IconPanel.Dock = DockStyle.Top;
            IconPanel.Location = new Point(0, 0);
            IconPanel.Name = "IconPanel";
            IconPanel.Size = new Size(358, 251);
            IconPanel.TabIndex = 0;
            // 
            // LogoPicture
            // 
            LogoPicture.Dock = DockStyle.Fill;
            LogoPicture.Image = Properties.Resources.PuertaAMilMundosLogo;
            LogoPicture.Location = new Point(0, 0);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(358, 251);
            LogoPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPicture.TabIndex = 0;
            LogoPicture.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(358, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(931, 630);
            MainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1289, 630);
            Controls.Add(MainPanel);
            Controls.Add(LateralPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            LateralPanel.ResumeLayout(false);
            IconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LateralPanel;
        private Panel MainPanel;
        private Panel IconPanel;
        private PictureBox LogoPicture;
        private FontAwesome.Sharp.IconButton BtnBooks;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton BtnUsers;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
