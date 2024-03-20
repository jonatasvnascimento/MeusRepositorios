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
    public partial class FormNewRegister : Form
    {
        private MyRepositoryService _myRepositoryService;
        public FormNewRegister()
        {
            InitializeComponent();
            _myRepositoryService = new MyRepositoryService();
        }

        private void btnSalve_Click(object sender, EventArgs e)
        {
            var retData = _myRepositoryService.SaveOrUpdateMyRepository(new MyRepository
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Linguagem = txtLinguagem.Text,
                DataAtualizacao = dtDataAtualizacao.Value,
                DonoRepositorio = txtDonoRepositorio.Text
            });

            if (retData)
            {//messagebox formatado
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
