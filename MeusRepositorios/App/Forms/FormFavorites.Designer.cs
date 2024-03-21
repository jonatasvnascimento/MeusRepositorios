namespace MeusRepositorios.App.Forms
{
    partial class FormFavorites
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
            dgvRepository = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Linguagem = new DataGridViewTextBoxColumn();
            DataAtualizacao = new DataGridViewTextBoxColumn();
            DonoRepositorio = new DataGridViewTextBoxColumn();
            txtFind = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRepository).BeginInit();
            SuspendLayout();
            // 
            // dgvRepository
            // 
            dgvRepository.AllowUserToAddRows = false;
            dgvRepository.AllowUserToDeleteRows = false;
            dgvRepository.AllowUserToResizeColumns = false;
            dgvRepository.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(236, 236, 236);
            dgvRepository.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRepository.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvRepository.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Descricao, Linguagem, DataAtualizacao, DonoRepositorio });
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
            dgvRepository.TabIndex = 6;
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
            // txtFind
            // 
            txtFind.BorderStyle = BorderStyle.FixedSingle;
            txtFind.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFind.Location = new Point(12, 12);
            txtFind.Multiline = true;
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(1066, 40);
            txtFind.TabIndex = 5;
            txtFind.TextChanged += txtFind_TextChanged;
            // 
            // FormFavorites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 76, 114);
            ClientSize = new Size(1090, 675);
            Controls.Add(dgvRepository);
            Controls.Add(txtFind);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFavorites";
            Text = "FormFavorites";
            Load += FormFavorites_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRepository).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRepository;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Linguagem;
        private DataGridViewTextBoxColumn DataAtualizacao;
        private DataGridViewTextBoxColumn DonoRepositorio;
        private TextBox txtFind;
    }
}