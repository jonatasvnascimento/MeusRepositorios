namespace MeusRepositorios.App.Forms
{
    partial class FormNewRegister
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
            txtNome = new TextBox();
            lblNome = new Label();
            lblTitleNewRegister = new Label();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblLinguagem = new Label();
            txtLinguagem = new TextBox();
            lblDataAtualizacao = new Label();
            lblDonoRepositorio = new Label();
            txtDonoRepositorio = new TextBox();
            btnSalve = new Button();
            btnCancel = new Button();
            dtDataAtualizacao = new DateTimePicker();
            cbFavorito = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(12, 92);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(493, 40);
            txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(12, 69);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // lblTitleNewRegister
            // 
            lblTitleNewRegister.AutoSize = true;
            lblTitleNewRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleNewRegister.ForeColor = Color.White;
            lblTitleNewRegister.Location = new Point(12, 9);
            lblTitleNewRegister.Name = "lblTitleNewRegister";
            lblTitleNewRegister.Size = new Size(130, 25);
            lblTitleNewRegister.TabIndex = 4;
            lblTitleNewRegister.Text = "Novo Registro";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescricao.ForeColor = Color.White;
            lblDescricao.Location = new Point(12, 135);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 6;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            txtDescricao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.Location = new Point(12, 158);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(493, 116);
            txtDescricao.TabIndex = 5;
            // 
            // lblLinguagem
            // 
            lblLinguagem.AutoSize = true;
            lblLinguagem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLinguagem.ForeColor = Color.White;
            lblLinguagem.Location = new Point(12, 277);
            lblLinguagem.Name = "lblLinguagem";
            lblLinguagem.Size = new Size(83, 20);
            lblLinguagem.TabIndex = 8;
            lblLinguagem.Text = "Linguagem";
            // 
            // txtLinguagem
            // 
            txtLinguagem.BorderStyle = BorderStyle.FixedSingle;
            txtLinguagem.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLinguagem.Location = new Point(12, 300);
            txtLinguagem.Multiline = true;
            txtLinguagem.Name = "txtLinguagem";
            txtLinguagem.Size = new Size(493, 40);
            txtLinguagem.TabIndex = 7;
            // 
            // lblDataAtualizacao
            // 
            lblDataAtualizacao.AutoSize = true;
            lblDataAtualizacao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataAtualizacao.ForeColor = Color.White;
            lblDataAtualizacao.Location = new Point(12, 409);
            lblDataAtualizacao.Name = "lblDataAtualizacao";
            lblDataAtualizacao.Size = new Size(123, 20);
            lblDataAtualizacao.TabIndex = 10;
            lblDataAtualizacao.Text = "Data Atualização";
            // 
            // lblDonoRepositorio
            // 
            lblDonoRepositorio.AutoSize = true;
            lblDonoRepositorio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDonoRepositorio.ForeColor = Color.White;
            lblDonoRepositorio.Location = new Point(12, 343);
            lblDonoRepositorio.Name = "lblDonoRepositorio";
            lblDonoRepositorio.Size = new Size(127, 20);
            lblDonoRepositorio.TabIndex = 12;
            lblDonoRepositorio.Text = "Dono Repositorio";
            // 
            // txtDonoRepositorio
            // 
            txtDonoRepositorio.BorderStyle = BorderStyle.FixedSingle;
            txtDonoRepositorio.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonoRepositorio.Location = new Point(12, 366);
            txtDonoRepositorio.Multiline = true;
            txtDonoRepositorio.Name = "txtDonoRepositorio";
            txtDonoRepositorio.Size = new Size(493, 40);
            txtDonoRepositorio.TabIndex = 11;
            // 
            // btnSalve
            // 
            btnSalve.BackColor = Color.White;
            btnSalve.FlatStyle = FlatStyle.Flat;
            btnSalve.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalve.Location = new Point(12, 473);
            btnSalve.Name = "btnSalve";
            btnSalve.Size = new Size(250, 40);
            btnSalve.TabIndex = 13;
            btnSalve.Text = "Salvar";
            btnSalve.UseVisualStyleBackColor = false;
            btnSalve.Click += btnSalve_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(268, 473);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(237, 40);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtDataAtualizacao
            // 
            dtDataAtualizacao.Location = new Point(12, 432);
            dtDataAtualizacao.Name = "dtDataAtualizacao";
            dtDataAtualizacao.Size = new Size(423, 23);
            dtDataAtualizacao.TabIndex = 15;
            // 
            // cbFavorito
            // 
            cbFavorito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbFavorito.ForeColor = Color.White;
            cbFavorito.Location = new Point(464, 432);
            cbFavorito.Name = "cbFavorito";
            cbFavorito.Size = new Size(13, 23);
            cbFavorito.TabIndex = 19;
            cbFavorito.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(443, 409);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 20;
            label1.Text = "Favorito";
            // 
            // FormNewRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 76, 114);
            ClientSize = new Size(517, 540);
            Controls.Add(label1);
            Controls.Add(cbFavorito);
            Controls.Add(dtDataAtualizacao);
            Controls.Add(btnCancel);
            Controls.Add(btnSalve);
            Controls.Add(lblDonoRepositorio);
            Controls.Add(txtDonoRepositorio);
            Controls.Add(lblDataAtualizacao);
            Controls.Add(lblLinguagem);
            Controls.Add(txtLinguagem);
            Controls.Add(lblDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(lblTitleNewRegister);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNewRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNewRegister";
            Load += FormNewRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lblNome;
        private Label lblTitleNewRegister;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblLinguagem;
        private TextBox txtLinguagem;
        private Label lblDataAtualizacao;
        private Label lblDonoRepositorio;
        private TextBox txtDonoRepositorio;
        private Button btnSalve;
        private Button btnCancel;
        private DateTimePicker dtDataAtualizacao;
        private Label lblFavorito;
        private ComboBox comboBox1;
        private CheckBox cbFavorito;
        private Label label1;
    }
}