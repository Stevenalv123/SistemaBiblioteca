namespace SistemaBiblioteca.Forms
{
    partial class Users
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            SearchPanel = new Panel();
            UsernamePanel = new Panel();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            LblUsers = new Label();
            MainPanel = new Panel();
            dtgUsers = new DataGridView();
            Cell_ID = new DataGridViewTextBoxColumn();
            Cell_Name = new DataGridViewTextBoxColumn();
            Cell_Adress = new DataGridViewTextBoxColumn();
            Cell_PhoneNumber = new DataGridViewTextBoxColumn();
            Cell_Email = new DataGridViewTextBoxColumn();
            Cell_DNI = new DataGridViewTextBoxColumn();
            TopPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsers).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(40, 68, 131);
            TopPanel.Controls.Add(SearchPanel);
            TopPanel.Controls.Add(LblUsers);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(931, 70);
            TopPanel.TabIndex = 0;
            // 
            // SearchPanel
            // 
            SearchPanel.Controls.Add(UsernamePanel);
            SearchPanel.Controls.Add(BtnSearch);
            SearchPanel.Controls.Add(TxtSearch);
            SearchPanel.Dock = DockStyle.Right;
            SearchPanel.Location = new Point(475, 0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(456, 70);
            SearchPanel.TabIndex = 3;
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = Color.White;
            UsernamePanel.Location = new Point(2, 49);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(332, 1);
            UsernamePanel.TabIndex = 8;
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.FromArgb(185, 27, 33);
            BtnSearch.Cursor = Cursors.Hand;
            BtnSearch.FlatStyle = FlatStyle.Popup;
            BtnSearch.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnSearch.ForeColor = Color.White;
            BtnSearch.Location = new Point(340, 15);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(104, 40);
            BtnSearch.TabIndex = 6;
            BtnSearch.Text = "Buscar";
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = Color.FromArgb(40, 68, 131);
            TxtSearch.BorderStyle = BorderStyle.None;
            TxtSearch.Cursor = Cursors.IBeam;
            TxtSearch.Font = new Font("Cambria", 20F);
            TxtSearch.ForeColor = Color.White;
            TxtSearch.HideSelection = false;
            TxtSearch.Location = new Point(3, 12);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Buscar usuario....";
            TxtSearch.Size = new Size(332, 32);
            TxtSearch.TabIndex = 4;
            // 
            // LblUsers
            // 
            LblUsers.AutoSize = true;
            LblUsers.Font = new Font("Cambria", 24F, FontStyle.Bold);
            LblUsers.ForeColor = Color.White;
            LblUsers.Location = new Point(12, 18);
            LblUsers.Name = "LblUsers";
            LblUsers.Size = new Size(148, 37);
            LblUsers.TabIndex = 2;
            LblUsers.Text = "Usuarios";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(dtgUsers);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 70);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(931, 560);
            MainPanel.TabIndex = 1;
            // 
            // dtgUsers
            // 
            dtgUsers.AllowUserToAddRows = false;
            dtgUsers.AllowUserToDeleteRows = false;
            dtgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgUsers.BackgroundColor = Color.White;
            dtgUsers.BorderStyle = BorderStyle.None;
            dtgUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsers.Columns.AddRange(new DataGridViewColumn[] { Cell_ID, Cell_Name, Cell_Adress, Cell_PhoneNumber, Cell_Email, Cell_DNI });
            dtgUsers.Dock = DockStyle.Fill;
            dtgUsers.Location = new Point(0, 0);
            dtgUsers.Name = "dtgUsers";
            dtgUsers.ReadOnly = true;
            dtgUsers.RowHeadersVisible = false;
            dtgUsers.Size = new Size(931, 560);
            dtgUsers.TabIndex = 0;
            // 
            // Cell_ID
            // 
            Cell_ID.HeaderText = "ID";
            Cell_ID.Name = "Cell_ID";
            Cell_ID.ReadOnly = true;
            // 
            // Cell_Name
            // 
            Cell_Name.HeaderText = "Nombre";
            Cell_Name.Name = "Cell_Name";
            Cell_Name.ReadOnly = true;
            // 
            // Cell_Adress
            // 
            Cell_Adress.HeaderText = "Direccion";
            Cell_Adress.Name = "Cell_Adress";
            Cell_Adress.ReadOnly = true;
            // 
            // Cell_PhoneNumber
            // 
            Cell_PhoneNumber.HeaderText = "Telefono";
            Cell_PhoneNumber.Name = "Cell_PhoneNumber";
            Cell_PhoneNumber.ReadOnly = true;
            // 
            // Cell_Email
            // 
            Cell_Email.HeaderText = "Correo Electronico";
            Cell_Email.Name = "Cell_Email";
            Cell_Email.ReadOnly = true;
            // 
            // Cell_DNI
            // 
            Cell_DNI.HeaderText = "Cedula de Identidad";
            Cell_DNI.Name = "Cell_DNI";
            Cell_DNI.ReadOnly = true;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(931, 630);
            Controls.Add(MainPanel);
            Controls.Add(TopPanel);
            Name = "Users";
            Text = "Users";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private Label LblUsers;
        private Panel UsernamePanel;
        private Panel SearchPanel;
        private Panel MainPanel;
        private DataGridView dtgUsers;
        private DataGridViewTextBoxColumn Cell_ID;
        private DataGridViewTextBoxColumn Cell_Name;
        private DataGridViewTextBoxColumn Cell_Adress;
        private DataGridViewTextBoxColumn Cell_PhoneNumber;
        private DataGridViewTextBoxColumn Cell_Email;
        private DataGridViewTextBoxColumn Cell_DNI;
    }
}