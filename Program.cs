using CsBases.Fundamentals;

class Program
{
  static void Main()
  {
    //Declaración explicíta
    int quantity = 5;
    string message = "Hello World";
    decimal price = 19.99m;
    //WriteLine($" Cantidad: {quantity}, Saludo: {message}, Precio: {price:C}");
    // Declaración con var
    var gretting = "Hola";
    var percentage = 20.00m;
    // WriteLine($" Saludo: {gretting}, Porcentaje: {percentage}");

    var laptop = new Product("Laptop", 1200);
    WriteLine(laptop.GetDescription());
    var soporte = new ServiceProduct("Soporte técnico", 300, 30);
    WriteLine(soporte.GetDescription());
  }
}