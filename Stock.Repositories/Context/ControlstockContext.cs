using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Stock.Entities.Entities;

namespace Stock.Repositories.Context
{
    public partial class ControlstockContext : DbContext
    {
        public ControlstockContext()
        {
        }

        public ControlstockContext(DbContextOptions < ControlstockContext > options): base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Departamento> Departamentos { get; set; }

        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; }

        public virtual DbSet<Marca> Marcas { get; set; }

        public virtual DbSet<Producto> Productos { get; set; }

        public virtual DbSet<Proveedor> Proveedors { get; set; }

        public virtual DbSet<Provincia> Provincias { get; set; }

        public virtual DbSet<Roles> Roles { get; set; }

        public virtual DbSet<Stock> Stocks { get; set; }

        public virtual DbSet<User> Usuario { get; set; }

        public virtual DbSet<Venta> Ventas { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
    }
}