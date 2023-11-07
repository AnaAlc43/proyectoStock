using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Stock.Repositories.Context
{
    public partial class ControlstockContext : DbContext
    {
        public ControlstockContext()
        {
        }

        public ControlstockContext(DbContextOptions<ControlstockContext> options) : base(options)
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

        public virtual DbSet<Usuario> Users { get; set; }

        public virtual DbSet<Venta> Ventas { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, //see http://go.microsoft.com/fwlink/?LinkId=723263.


        //    => optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;database=controlstock;user=root;password=root");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.Idcategorias).HasName("PRIMARY");

                entity.ToTable("categorias");

                entity.Property(e => e.Idcategorias).HasColumnName("idcategorias");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .HasColumnName("descripcion");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Idcliente).HasName("PRIMARY");

                entity.ToTable("clientes");

                entity.Property(e => e.Idcliente).HasColumnName("idcliente");
                entity.Property(e => e.Apellido)
                    .HasMaxLength(45)
                    .HasColumnName("apellido");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .HasColumnName("descripcion");
                entity.Property(e => e.Direccion)
                    .HasMaxLength(45)
                    .HasColumnName("direccion");
                entity.Property(e => e.DniCuil)
                    .HasMaxLength(45)
                    .HasColumnName("dni/cuil");
                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .HasColumnName("email");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento).HasName("PRIMARY");

                entity.ToTable("departamento");

                entity.HasIndex(e => e.Provincia, "provincia_idx");

                entity.Property(e => e.IdDepartamento).HasColumnName("idDepartamento");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .HasColumnName("descripcion");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
                entity.Property(e => e.Provincia).HasColumnName("provincia");

                entity.HasOne(d => d.ProvinciaNavigation).WithMany(p => p.Departamentos)
                    .HasForeignKey(d => d.Provincia)
                    .HasConstraintName("provincia");
            });

            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.HasKey(e => e.IddetalleVenta).HasName("PRIMARY");

                entity.ToTable("detalle_ventas");

                entity.HasIndex(e => e.Producto, "detalle_ventas_idx");

                entity.HasIndex(e => e.Producto, "producto_idx");

                entity.HasIndex(e => e.Venta, "venta_idx");

                entity.Property(e => e.IddetalleVenta).HasColumnName("iddetalle_venta");
                entity.Property(e => e.Cantidad).HasColumnName("cantidad");
                entity.Property(e => e.EstadoDetalleVenta)
                    .HasMaxLength(45)
                    .HasColumnName("estado_detalle_venta");
                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");
                entity.Property(e => e.PrecioVenta)
                    .HasMaxLength(45)
                    .HasColumnName("precio_venta");
                entity.Property(e => e.Producto).HasColumnName("producto");
                entity.Property(e => e.Venta).HasColumnName("venta");

                entity.HasOne(d => d.ProductoNavigation).WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.Producto)
                    .HasConstraintName("detalle_ventas");

                entity.HasOne(d => d.VentaNavigation).WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.Venta)
                    .HasConstraintName("venta");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.Idmarca).HasName("PRIMARY");

                entity.ToTable("marcas");

                entity.Property(e => e.Idmarca).HasColumnName("idmarca");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .HasColumnName("descripcion");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Idproducto).HasName("PRIMARY");

                entity.ToTable("producto");

                entity.HasIndex(e => e.Stock, "stock_idx");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(45)
                    .HasColumnName("codigo");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(145)
                    .HasColumnName("descripcion");
                entity.Property(e => e.EstadoProd)
                    .HasMaxLength(45)
                    .HasColumnName("estado_prod");
                entity.Property(e => e.Imagen)
                    .HasMaxLength(45)
                    .HasColumnName("imagen");
                entity.Property(e => e.Lote)
                    .HasMaxLength(45)
                    .HasColumnName("lote");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
                entity.Property(e => e.Peso)
                    .HasMaxLength(45)
                    .HasColumnName("peso");
                entity.Property(e => e.Stock).HasColumnName("stock");
                entity.Property(e => e.Vencimiento)
                    .HasMaxLength(45)
                    .HasColumnName("vencimiento");

                entity.HasOne(d => d.StockNavigation).WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Stock)
                    .HasConstraintName("stock");

                entity.HasMany(d => d.IdProveedors).WithMany(p => p.IdProductos)
                    .UsingEntity<Dictionary<string, object>>(
                        "Productoxproveedor",
                        r => r.HasOne<Proveedor>().WithMany()
                            .HasForeignKey("IdProveedor")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("proveedor"),
                        l => l.HasOne<Producto>().WithMany()
                            .HasForeignKey("IdProducto")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("producto"),
                        j =>
                        {
                            j.HasKey("IdProducto", "IdProveedor").HasName("PRIMARY");
                            j.ToTable("productoxproveedor");
                            j.HasIndex(new[] { "IdProveedor" }, "productoxproveedor_idx");
                            j.IndexerProperty<int>("IdProducto").HasColumnName("idProducto");
                            j.IndexerProperty<int>("IdProveedor").HasColumnName("idProveedor");
                        });
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.Idproveedor).HasName("PRIMARY");

                entity.ToTable("proveedor");

                entity.HasIndex(e => e.Localidad, "localidad_idx");

                entity.Property(e => e.Idproveedor).HasColumnName("idproveedor");
                entity.Property(e => e.Contacto)
                    .HasMaxLength(45)
                    .HasColumnName("contacto");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .HasColumnName("descripcion");
                entity.Property(e => e.Direccion)
                    .HasMaxLength(45)
                    .HasColumnName("direccion");
                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .HasColumnName("email");
                entity.Property(e => e.Fechaderegistro)
                    .HasColumnType("date")
                    .HasColumnName("fechaderegistro");
                entity.Property(e => e.Localidad).HasColumnName("localidad");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
                entity.Property(e => e.Telefono)
                    .HasMaxLength(45)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.LocalidadNavigation).WithMany(p => p.Proveedors)
                    .HasForeignKey(d => d.Localidad)
                    .HasConstraintName("localidad");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.Idprovincia).HasName("PRIMARY");

                entity.ToTable("provincias");

                entity.Property(e => e.Idprovincia).HasColumnName("idprovincia");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .HasColumnName("descripcion");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("roles");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .HasColumnName("descripcion");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.IdStock).HasName("PRIMARY");

                entity.ToTable("stock");

                entity.HasIndex(e => e.Categoria, "categoria_idx");

                entity.HasIndex(e => e.Marca, "marca_idx");

                entity.Property(e => e.IdStock).HasColumnName("idStock");
                entity.Property(e => e.Categoria).HasColumnName("categoria");
                entity.Property(e => e.Codigo)
                    .HasMaxLength(45)
                    .HasColumnName("codigo");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(140)
                    .HasColumnName("descripcion");
                entity.Property(e => e.EstadoStock)
                    .HasMaxLength(45)
                    .HasColumnName("estado_stock");
                entity.Property(e => e.Marca).HasColumnName("marca");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.CategoriaNavigation).WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.Categoria)
                    .HasConstraintName("categoria");

                entity.HasOne(d => d.MarcaNavigation).WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.Marca)
                    .HasConstraintName("marca");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario).HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.Rol, "roles_idx");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");
                entity.Property(e => e.Apellido)
                    .HasMaxLength(45)
                    .HasColumnName("apellido");
                entity.Property(e => e.Cuil)
                    .HasMaxLength(45)
                    .HasColumnName("cuil");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .HasColumnName("descripcion");
                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .HasColumnName("email");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
                entity.Property(e => e.NumeroTelefono)
                    .HasMaxLength(45)
                    .HasColumnName("numeroTelefono");
                entity.Property(e => e.Rol).HasColumnName("rol");

                entity.HasOne(d => d.RolNavigation).WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Rol)
                    .HasConstraintName("roles");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.IdVenta).HasName("PRIMARY");

                entity.ToTable("ventas");

                entity.HasIndex(e => e.Cliente, "cliente_idx");

                entity.HasIndex(e => e.Usuario, "usuario_idx");

                entity.Property(e => e.IdVenta).HasColumnName("idVenta");
                entity.Property(e => e.Cliente).HasColumnName("cliente");
                entity.Property(e => e.DetalleProducto)
                    .HasMaxLength(45)
                    .HasColumnName("detalle_producto");
                entity.Property(e => e.EstadoVenta)
                    .HasMaxLength(45)
                    .HasColumnName("estado_venta");
                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");
                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.HasOne(d => d.ClienteNavigation).WithMany(p => p.Venta)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("cliente");

                entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Venta)
                    .HasForeignKey(d => d.Usuario)
                    .HasConstraintName("usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        
    }
}