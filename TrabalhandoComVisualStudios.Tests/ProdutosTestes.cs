using System;
using System.Collections.Generic;
using System.Text;
using TrabalhandoComVisualStudios.Models;
using Xunit;

namespace TrabalhandoComVisualStudios.Tests
{
    public class ProdutosTestes
    {
        [Fact]
        public void PossoMudarONomeDoProduto()
        {
            //Arrange
            var produto = new Produto()
            {
                Nome="Teste",Preco=100M
            };

            //Act
            produto.Nome = "Nome novo";

            //Assert
            Assert.Equal("Nome novo",produto.Nome);
        }

        [Fact]
        public void PossoMudarOPrecoDoProduto()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "Teste",
                Preco = 100M

            };
            //Act
            produto.Preco = 200M;

            //Assert
            Assert.Equal(200M,produto.Preco);
        }

    }
}
