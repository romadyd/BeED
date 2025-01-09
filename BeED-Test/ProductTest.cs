using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BeED.Data;
using BeED.Interfaces;
using BeED.Models;
using BeED.Services;
using Dapper;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;

namespace BeED.Tests
{
    [TestFixture]
    public class ProductServiceTests
    {
        private Mock<IDbConnection> _mockConnection;
        private IConfiguration _mockConfiguration;
        private ProductService _productService;

        [SetUp]
        public void Setup()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _mockConnection = new Mock<IDbConnection>();
            _mockConfiguration = builder.Build();
            _productService = new ProductService(_mockConfiguration);
        }

        [Test]
        public async Task GetAllProductTest()
        {
            // Act
            var result = await _productService.GetAllProduct();

            // Assert
            Assert.NotNull(result);
            Assert.Greater(result.TotalRows, 0);
        }
    }
}
