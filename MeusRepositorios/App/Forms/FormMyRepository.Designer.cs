namespace MeusRepositorios.App.Forms
{
    partial class FormMyRepository
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtFind = new TextBox();
            btnCreate = new Button();
            dgvRepository = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Linguagem = new DataGridViewTextBoxColumn();
            DataAtualizacao = new DataGridViewTextBoxColumn();
            DonoRepositorio = new DataGridViewTextBoxColumn();
            Acao = new DataGridViewButtonColumn();
            btnDeleteAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRepository).BeginInit();
            SuspendLayout();
            // 
            // txtFind
            // 
            txtFind.BorderStyle = BorderStyle.FixedSingle;
            txtFind.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFind.Location = new Point(12, 12);
            txtFind.Multiline = true;
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(816, 40);
            txtFind.TabIndex = 1;
            txtFind.TextChanged += tbxFind_TextChanged;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.White;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(834, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(118, 40);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Novo Registro";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvRepository
            // 
            dgvRepository.AllowUserToAddRows = false;
            dgvRepository.AllowUserToDeleteRows = false;
            dgvRepository.AllowUserToResizeColumns = false;
            dgvRepository.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(236, 236, 236);
            dgvRepository.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRepository.BackgroundColor = Color.White;
            dgvRepository.BorderStyle = BorderStyle.None;
            dgvRepository.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(79, 101, 122);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(79, 101, 122);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRepository.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRepository.ColumnHeadersHeight = 40;
            dgvRepository.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Descricao, Linguagem, DataAtualizacao, DonoRepositorio, Acao });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(16, 158, 177);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRepository.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRepository.EnableHeadersVisualStyles = false;
            dgvRepository.GridColor = Color.White;
            dgvRepository.Location = new Point(12, 59);
            dgvRepository.MultiSelect = false;
            dgvRepository.Name = "dgvRepository";
            dgvRepository.ReadOnly = true;
            dgvRepository.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRepository.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvRepository.RowTemplate.Height = 50;
            dgvRepository.RowTemplate.ReadOnly = true;
            dgvRepository.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvRepository.ScrollBars = ScrollBars.Vertical;
            dgvRepository.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRepository.Size = new Size(1066, 604);
            dgvRepository.TabIndex = 4;
            dgvRepository.CellClick += dgvRepository_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 88;
            // 
            // Descricao
            // 
            Descricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Resizable = DataGridViewTriState.True;
            // 
            // Linguagem
            // 
            Linguagem.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Linguagem.HeaderText = "Linguagem";
            Linguagem.Name = "Linguagem";
            Linguagem.ReadOnly = true;
            Linguagem.Width = 137;
            // 
            // DataAtualizacao
            // 
            DataAtualizacao.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataAtualizacao.HeaderText = "DataAtualizacao";
            DataAtualizacao.Name = "DataAtualizacao";
            DataAtualizacao.ReadOnly = true;
            DataAtualizacao.Width = 191;
            // 
            // DonoRepositorio
            // 
            DonoRepositorio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DonoRepositorio.HeaderText = "DonoRepositorio";
            DonoRepositorio.Name = "DonoRepositorio";
            DonoRepositorio.ReadOnly = true;
            DonoRepositorio.Width = 182;
            // 
            // Acao
            // 
            Acao.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Acao.FillWeight = 60F;
            Acao.HeaderText = "Ação";
            Acao.Name = "Acao";
            Acao.ReadOnly = true;
            Acao.Width = 60;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.White;
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteAll.Location = new Point(958, 12);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(120, 40);
            btnDeleteAll.TabIndex = 2;
            btnDeleteAll.Text = "Deletar Todos";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // FormMyRepository
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 76, 114);
            ClientSize = new Size(1090, 675);
            Controls.Add(dgvRepository);
            Controls.Add(btnCreate);
            Controls.Add(btnDeleteAll);
            Controls.Add(txtFind);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMyRepository";
            Text = "FormMyRepository";
            Load += FormMyRepository_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRepository).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFind;
        private Button btnCreate;
        private DataGridView dgvRepository;
        private Button btnDeleteAll;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Linguagem;
        private DataGridViewTextBoxColumn DataAtualizacao;
        private DataGridViewTextBoxColumn DonoRepositorio;
        private DataGridViewButtonColumn Acao;
    }
}