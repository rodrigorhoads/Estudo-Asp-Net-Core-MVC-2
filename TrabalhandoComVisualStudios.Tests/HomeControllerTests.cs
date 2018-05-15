using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using TrabalhandoComVisualStudios.Controllers;
using TrabalhandoComVisualStudios.Models;
using Xunit;

namespace TrabalhandoComVisualStudios.Tests
{
    public class HomeControllerTests
    {

        //class ModeloCompletoFalsoRepository : IRepository
        //{
        //    public IEnumerable<Produto> Produtos { get; set; }

        //    public void AddProdutos(Produto produto)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        [Theory]
        [ClassData(typeof(ProdutoTesteDado))]
        public void IndexActionModelIsComplete(Produto[] produtos)
        {
            //Arrange
            var mock = new Mock<IRepository>();
            mock.SetupGet(m=>m.Produtos).Returns(produtos);
            var controller = new HomeController() { Repository = mock.Object};
            //Act
            var model = (controller.Index() as ViewResult)?
                .ViewData.Model as IEnumerable<Produto>;

            //Assert
            Assert.Equal(controller.Repository.Produtos, model,
                Comparer.Get<Produto>((produto1,
                produto2) => produto1.Nome == produto2.Nome &&
                produto1.Preco == produto2.Preco));
        }

        //class PropertyOnceFakeRepository : IRepository
        //{
        //    public int PropertyCounter { get; set; } = 0;

        //    public IEnumerable<Produto> Produtos
        //    {
        //        get
        //        {
        //            PropertyCounter++;
        //            return new[] { new Produto { Nome = "P1", Preco = 100 } };
        //        }
        //    }

        //    public void AddProdutos(Produto p){ }
            
        //}
        [Fact]
        public void RepositoryPropertyCalledOnce()
        {
            //Arrange
            var mock =new Mock<IRepository>();
            mock.SetupGet(m => m.Produtos).Returns(new[] { new Produto { Nome = "P1", Preco = 100 } });

            var controller = new HomeController() { Repository=mock.Object};

            //Act
            var result = controller.Index();

            //Assert
            mock.VerifyGet(m=>m.Produtos,Times.Once);
        }



      
    }
}
