using MeusRepositorios.Domain.Model;
using MeusRepositorios.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeusRepositorios.App.Forms
{
    public partial class FormMyRepository : Form
    {
        private MyRepositoryService _myRepositoryService;
        public List<MyRepository> myRepository { get; set; }
        public FormMyRepository()
        {
            InitializeComponent();
            _myRepositoryService = new MyRepositoryService();
        }

        private void FormMyRepository_Load(object sender, EventArgs e)
        {
            LoadRepository();
        }

        private void LoadRepository()
        {
            myRepository = _myRepositoryService.Get().ToList();

            dgvRepository.Columns["Id"].DataPropertyName = "Id";
            dgvRepository.Columns["Nome"].DataPropertyName = "Nome";
            dgvRepository.Columns["Descricao"].DataPropertyName = "Descricao";
            dgvRepository.Columns["Linguagem"].DataPropertyName = "Linguagem";
            dgvRepository.Columns["DataAtualizacao"].DataPropertyName = "DataAtualizacao";
            dgvRepository.Columns["DonoRepositorio"].DataPropertyName = "DonoRepositorio";

            dgvRepository.AutoGenerateColumns = false;
            dgvRepository.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvRepository.DataSource = myRepository.Select(x => new
            {
                Id = x.Id,
                Nome = x.Nome,
                Descricao = x.Descricao,
                Linguagem = x.Linguagem,
                DataAtualizacao = x.DataAtualizacao,
                DonoRepositorio = x.DonoRepositorio
            }).ToList();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormNewRegister formNewRegister = new FormNewRegister();
            formNewRegister.ShowDialog();
            LoadRepository();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja deletar todos os registros?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var retData = _myRepositoryService.DeleteAll();
                if (retData)
                {
                    MessageBox.Show("Registro deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadRepository();
            }

        }
    }
}
