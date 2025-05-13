using CsBases.Fundamentals;

class Program
{
  static void Main()
  {
    var laptop = new Product("Laptop", 1200);
    WriteLine(laptop.GetDescription());
    var soporte = new ServiceProduct("Soporte técnico", 300, 30);
    WriteLine(soporte.GetDescription());
    var product = new Product("Mouse Gamer", 300);
    var productDto = ProductAdapter.ToDto(product);
    WriteLine($"{productDto.Name} - {productDto.Price:C} - Código: {productDto.Code}");
  }
}