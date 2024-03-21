using MeusRepositorios.Domain.Interface;
using MeusRepositorios.Domain.Model;
using MeusRepositorios.Domain.Repository;
using MeusRepositorios.Service.Services;
using Moq;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeusRepositorios.Tests
{
    public class MeusRepositoriosTests
    {
        private readonly MyRepositoryRepository _myRepositoryRepository = new MyRepositoryRepository();

        private readonly FavoriteRepository _favoriteRepository = new FavoriteRepository();

        [Fact]
        public void DadoQueInsercaoValida_Entao_InserirComSucesso()
        {
            //Arrange
            var favorite = new Favorite()
            {
                MyRepositoryId = 1,
                Nome = "teste",
                Descricao = "teste",
                Linguagem = "teste",
                DataAtualizacao = DateTime.Now,
                DonoRepositorio = "teste"
            };


            MyRepository myRepository = new MyRepository()
            {
                Nome = "Teste",
                Descricao = "Teste",
                Linguagem = "Teste",
                DataAtualizacao = DateTime.Now,
                DonoRepositorio = "Teste"
            };

            //Act

            var ret = _myRepositoryRepository.SaveOrUpdateMyRepository(myRepository, favorite);

            //Assert
            Assert.True(ret);
        }

        [Fact]
        public void GetById_ReturnsMyRepository()
        {
            // Arrange
            var id = 1;

            // Act
            var result = _myRepositoryRepository.GetById(id);

            // Assert
            Assert.NotNull(result);
        }


        [Fact]
        public void Get_ReturnsQueryable()
        {
            // Act
            var result = _myRepositoryRepository.Get();

            // Assert
            Assert.NotNull(result);
            // Add more assertions as needed
        }

        [Fact]
        public void DeleteAll_ReturnsTrue()
        {
            // Act
            var result = _myRepositoryRepository.DeleteAll();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Get_ReturnsQueryableFavorite()
        {
            // Act
            var result = _favoriteRepository.Get();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void SaveOrUpdateFavorite_ReturnsTrue()
        {
            // Arrange
            var favorite = new Favorite()
            {
                MyRepositoryId = 1,
                Nome = "teste",
                Descricao = "teste",
                Linguagem = "teste",
                DataAtualizacao = DateTime.Now,
                DonoRepositorio = "teste"
            };

            // Act
            var result = _favoriteRepository.SaveOrUpdateFavorite(favorite);

            // Assert
            Assert.True(result);
        }

    }
}