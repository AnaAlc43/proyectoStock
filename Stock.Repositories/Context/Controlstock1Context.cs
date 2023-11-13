using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Stock.COMMON.Entities;

namespace Stock.Repositories.Context;

public partial class Controlstock1Context : DbContext
{
    public Controlstock1Context()
    {
    }

    public Controlstock1Context(DbContextOptions<Controlstock1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<Roles> Roles { get; set; }

    public virtual DbSet<Sales> Sales { get; set; }

    public virtual DbSet<Salesdetail> Salesdetails { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}

    // Este método se llama al configurar el modelo de base de datos.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Aplica configuraciones de entidades desde el ensamblado actual.
        modelBuilder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly());
    }

}
