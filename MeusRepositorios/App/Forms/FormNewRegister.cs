using MeusRepositorios.Domain.Model;
using MeusRepositorios.Service.Interface;
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
    public partial class FormNewRegister : Form
    {
        private readonly MyRepositoryService _myRepositoryService;
        private readonly FavoriteService _favoriteService;
        private bool _isCreate { get; set; }
        public FormNewRegister(bool isCreate = true)
        {
            InitializeComponent();
            _myRepositoryService = new MyRepositoryService();
            _favoriteService = new FavoriteService();
            _isCreate = isCreate;
        }

        private void FormNewRegister_Load(object sender, EventArgs e)
        {
            if (_isCreate)
            {
                dtDataAtualizacao.Enabled = false;
            }
        }

        private void btnSalve_Click(object sender, EventArgs e)
        {
            var retData = _myRepositoryService.SaveOrUpdateMyRepository(new MyRepository
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Linguagem = txtLinguagem.Text,
                DataAtualizacao = dtDataAtualizacao.Value,
                DonoRepositorio = txtDonoRepositorio.Text,
                isFavorite = cbFavorito.CheckState == CheckState.Checked ? true : false
            });

            if (retData)
            {
                MessageBox.Show("Registro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao salvar o registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
