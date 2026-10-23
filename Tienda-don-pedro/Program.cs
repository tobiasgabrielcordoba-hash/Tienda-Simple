using var Company.ClassLibrary1;

using var context = new AppDbContext();
var servicio = new ProductoService(context);

servicio.Agregar("Mouse",13000);
servicio.Agregar("Teclado",9245);
servicio.Agregar("Auris",3554);

Console.WriteLine("------Lista de Productos El Pepe------ \n");

foreach (var p in servicio.ObtenerTodos())
{

    Console.WriteLine($"{p.Id} - {p.Nombre} - ${p.Precio}");

}
