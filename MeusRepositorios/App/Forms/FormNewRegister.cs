﻿using MeusRepositorios.Domain.Model;
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
        private int _idRepository { get; set; }
        private MyRepository MyRepository { get; set; } = new MyRepository();
        public FormNewRegister(bool isCreate = true, int idRepository = -1)
        {
            InitializeComponent();
            _myRepositoryService = new MyRepositoryService();
            _favoriteService = new FavoriteService();
            _isCreate = isCreate;
            _idRepository = idRepository;
        }

        private void FormNewRegister_Load(object sender, EventArgs e)
        {
            if (_isCreate)
            {
                dtDataAtualizacao.Enabled = false;
            }
            else
            {
                dtDataAtualizacao.Enabled = false;
                LoadRepository();
            }
        }

        private void LoadRepository()
        {
            MyRepository = _myRepositoryService.GetById(_idRepository);

            if (MyRepository != null)
            {
                txtNome.Text = MyRepository.Nome;
                txtDescricao.Text = MyRepository.Descricao;
                txtLinguagem.Text = MyRepository.Linguagem;
                dtDataAtualizacao.Value = MyRepository.DataAtualizacao;
                txtDonoRepositorio.Text = MyRepository.DonoRepositorio;
                cbFavorito.CheckState = _favoriteService.Get().Any(x => x.MyRepositoryId == MyRepository.Id) == true ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        private void btnSalve_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isCreate)
                {
                    MyRepository = new MyRepository()
                    {
                        Nome = txtNome.Text,
                        Descricao = txtDescricao.Text,
                        Linguagem = txtLinguagem.Text,
                        DataAtualizacao = dtDataAtualizacao.Value,
                        DonoRepositorio = txtDonoRepositorio.Text,
                        isFavorite = cbFavorito.CheckState == CheckState.Checked ? true : false
                    };
                }
                else
                {
                    MyRepository.Nome = txtNome.Text;
                    MyRepository.Descricao = txtDescricao.Text;
                    MyRepository.Linguagem = txtLinguagem.Text;
                    MyRepository.DonoRepositorio = txtDonoRepositorio.Text;
                    MyRepository.DataAtualizacao = DateTime.Now;
                    MyRepository.isFavorite = cbFavorito.CheckState == CheckState.Checked ? true : false;
                }

                var retData = _myRepositoryService.SaveOrUpdateMyRepository(MyRepository);

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
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
