using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using Microsoft.AspNetCore.Mvc;



namespace SportsStore.Tests
{
  /*  public class HomeControllerTest
    {
        [Fact]
      public void Can_Use_Reository()
        {
            Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
            mock.Setup(m => m.Products).Returns((new Product[]
            {
                new Product {ProductID = 1, Name = "P1"},
                new Product {ProductID = 2, Name = "P2"}
            }).AsQueryable<Product>);
            HomeController controller = new HomeController(mock.Object);
            IEnumerable<Product> result = (controller.Index() as ViewResult).ViewData.Model as IEnumerable<Product>;
            Product[] prodArray = result.ToArray();
            Assert.Equal("P1", prodArray[0].Name);
            Assert.Equal("P2", prodArray[1].Name);

        }
    }*/
}
