using CsBases.Fundamentals;

namespace CsBases;

internal class Program
{
    private static async Task Main()
    {
        var laptop = new Product("Laptop", 1200);
        WriteLine(laptop.GetDescription());
        var support = new ServiceProduct("Technical Support", 300, 30);
        WriteLine(support.GetDescription());
        var product = new Product("Mouse Gamer", 300);
        var productDto = ProductAdapter.ToDto(product);
        WriteLine($"{productDto.Name} - {productDto.Price:C} - Código: {productDto.Code}");

        // Dependency Injection
        ILabelService labelService = new LabelService();
        var manager = new ProductManager(labelService);
        var monitor = new Product("Monitor", 100);
        var installation = new ServiceProduct("Instalación de monitor", 20, 30);
        manager.PrintLabel(monitor);
        manager.PrintLabel(installation);
        var firstProduct = await new ProductRepository().GetProduct(1);
        firstProduct.Description = "Esta es la descripción del primer producto";
        AttributeProcessor.ApplyUpperCase(firstProduct);
        WriteLine($"{firstProduct.Name} - {firstProduct.Price} - {firstProduct.Description}");
    }
}