class Program
{
  static void Main()
  {
    //Declaración explicíta
    int quantity = 5;
    string message = "Hello Wolrd";
    decimal price = 19.99m;
    WriteLine($" Cantidad: {quantity}, Saludo: {message}, Precio: {price:C}");
    // Declaración con var
    var gretting = "Hola";
    var porcentage = 20.00m;
    WriteLine($" Saludo: {gretting}, Porcentaje: {porcentage}");
  }
}