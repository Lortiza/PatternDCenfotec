namespace Exercise_3DesignPatterns
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var customer = new Customer { Id = 1, Name = "John Doe", Address = "123 Main St" };

            var product1 = new Product { Id = 1, Name = "Product 1", Price = 10 };
            var product2 = new Product { Id = 2, Name = "Product 2", Price = 20 };

            var order = new Order(customer);
            order.AddOrderItem(new OrderItem { Product = product1, Quantity = 2 });
            order.AddOrderItem(new OrderItem { Product = product2, Quantity = 1 });

            decimal expectedTotalPrice = 40;

            // Act
            decimal actualTotalPrice = order.CalculateTotalPrice();

            // Assert
            Assert.Equal(expectedTotalPrice, actualTotalPrice);
        }
    }
}