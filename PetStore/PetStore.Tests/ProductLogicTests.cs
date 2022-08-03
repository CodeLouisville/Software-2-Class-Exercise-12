using Moq;
using PetStore.Data;

namespace PetStore.Tests
{
    [TestClass]
    public class ProductLogicTests
    {
        private readonly Mock<IProductRepository> _productRepositoryMock;
        private readonly Mock<IOrderRepository> _orderRepositoryMock;

        private readonly ProductLogic _productLogic;

        public ProductLogicTests()
        {
            _productRepositoryMock = new Mock<IProductRepository>();
            _orderRepositoryMock = new Mock<IOrderRepository>();

            _productLogic = new ProductLogic(_productRepositoryMock.Object, _orderRepositoryMock.Object);
        }

        [TestMethod]
        public async Task GetProductById_CallsRepo()
        {
            // Arrange
            _productRepositoryMock.Setup(x => x.GetProductByIdAsync(10))
                .ReturnsAsync(new Product { ProductId = 10, Name = "test product" });

            // Act
            await _productLogic.GetProductByIdAsync(10);

            // Assert
            _productRepositoryMock.Verify(x => x.GetProductByIdAsync(10), Times.Once);
        }
    }
}