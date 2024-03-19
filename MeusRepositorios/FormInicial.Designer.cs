namespace MeusRepositorios
{
    partial class FormInicial
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
            panelMenu = new Panel();
            btnFavorites = new Button();
            btnMyRepository = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            btnClose = new Button();
            btnMinimize = new Button();
            btnMaximaze = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnFavorites);
            panelMenu.Controls.Add(btnMyRepository);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(233, 782);
            panelMenu.TabIndex = 0;
            // 
            // btnFavorites
            // 
            btnFavorites.Dock = DockStyle.Top;
            btnFavorites.FlatAppearance.BorderSize = 0;
            btnFavorites.FlatStyle = FlatStyle.Flat;
            btnFavorites.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFavorites.ForeColor = Color.White;
            btnFavorites.Location = new Point(0, 160);
            btnFavorites.Name = "btnFavorites";
            btnFavorites.Size = new Size(233, 54);
            btnFavorites.TabIndex = 2;
            btnFavorites.Text = "Favoritos";
            btnFavorites.UseVisualStyleBackColor = true;
            btnFavorites.Click += btnFavorites_Click;
            // 
            // btnMyRepository
            // 
            btnMyRepository.Dock = DockStyle.Top;
            btnMyRepository.FlatAppearance.BorderSize = 0;
            btnMyRepository.FlatStyle = FlatStyle.Flat;
            btnMyRepository.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMyRepository.ForeColor = Color.White;
            btnMyRepository.Location = new Point(0, 106);
            btnMyRepository.Name = "btnMyRepository";
            btnMyRepository.Size = new Size(233, 54);
            btnMyRepository.TabIndex = 1;
            btnMyRepository.Text = "Meus Repositorios";
            btnMyRepository.UseVisualStyleBackColor = true;
            btnMyRepository.Click += btnMyRepository_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(233, 106);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 45);
            label1.Name = "label1";
            label1.Size = new Size(100, 18);
            label1.TabIndex = 0;
            label1.Text = "MyRepository";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximaze);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(233, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(873, 106);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackgroundImage = Properties.Resources.icons8_macos_close_60;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Calibri Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(840, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackgroundImage = Properties.Resources.icons8_macos_minimizar_60;
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Calibri Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(768, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 2;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximaze
            // 
            btnMaximaze.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximaze.BackgroundImage = Properties.Resources.icons8_tela_completa_macos_60;
            btnMaximaze.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximaze.FlatAppearance.BorderSize = 0;
            btnMaximaze.FlatStyle = FlatStyle.Flat;
            btnMaximaze.Font = new Font("Calibri Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMaximaze.ForeColor = Color.White;
            btnMaximaze.Location = new Point(804, 5);
            btnMaximaze.Name = "btnMaximaze";
            btnMaximaze.Size = new Size(30, 30);
            btnMaximaze.TabIndex = 1;
            btnMaximaze.UseVisualStyleBackColor = true;
            btnMaximaze.Click += btnMaximaze_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(379, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(68, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(233, 106);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(873, 676);
            panelDesktopPane.TabIndex = 2;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1106, 782);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormInicial";
            Text = "Form1";
            Load += FormInicial_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnMyRepository;
        private Panel panelLogo;
        private Label label1;
        private Button btnFavorites;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPane;
        private Button btnMaximaze;
        private Button btnClose;
        private Button btnMinimize;
    }
}
