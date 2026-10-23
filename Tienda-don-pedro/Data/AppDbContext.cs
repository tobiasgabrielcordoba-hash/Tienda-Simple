using System;

namespace Company.ClassLibrary1;

public class AppDbContext : DbContext
{

    public DbSet <Producto> Productos {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        var connecitionString = "Server=localhost;Database=TiendaPedro;User=root;Password=tupass;";
        optionsBuilder.UseMySql(connecitionString, ServerVersion.AutoDetect(connecitionString));

    }

}
