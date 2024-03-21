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
    public partial class FormFavorites : Form
    {
        private readonly FavoriteService _favoriteService;
        public List<Favorite> favorites { get; set; }
        public FormFavorites()
        {
            InitializeComponent();
            _favoriteService = new FavoriteService();
        }

        private void FormFavorites_Load(object sender, EventArgs e)
        {
            LoadFavorites();
        }

        private void LoadFavorites(string find = "")
        {
            try
            {
                if (!string.IsNullOrEmpty(find))
                {
                    favorites = _favoriteService.Get().Where(x => x.Nome.ToUpper().Contains(find.ToUpper())).ToList();
                }
                else
                {
                    favorites = _favoriteService.Get().ToList();
                }

                dgvRepository.Columns["Id"].DataPropertyName = "Id";
                dgvRepository.Columns["Nome"].DataPropertyName = "Nome";
                dgvRepository.Columns["Descricao"].DataPropertyName = "Descricao";
                dgvRepository.Columns["Linguagem"].DataPropertyName = "Linguagem";
                dgvRepository.Columns["DataAtualizacao"].DataPropertyName = "DataAtualizacao";
                dgvRepository.Columns["DonoRepositorio"].DataPropertyName = "DonoRepositorio";

                dgvRepository.AutoGenerateColumns = false;
                dgvRepository.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                dgvRepository.DataSource = favorites.Select(x => new
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Descricao = x.Descricao,
                    Linguagem = x.Linguagem,
                    DataAtualizacao = x.DataAtualizacao,
                    DonoRepositorio = x.DonoRepositorio
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            LoadFavorites(txtFind.Text);
        }
    }
}
