using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.COMMON.Entities;

namespace Stock.Repositories.EFCore.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("users");
            {
                builder.HasKey(e => e.IdUser).HasName("PRIMARY");

                builder.HasIndex(e => e.Rol, "rol_idx");

                builder.Property(e => e.IdUser).HasColumnName("idUser");
                builder.Property(e => e.Apellido)
                        .HasMaxLength(45)
                        .HasColumnName("apellido");
                builder.Property(e => e.CUIT)
                        .HasMaxLength(45)
                        .HasColumnName("cuit");
                builder.Property(e => e.Descripcion)
                        .HasMaxLength(45)
                        .HasColumnName("descripcion");
                builder.Property(e => e.Email)
                        .HasMaxLength(45)
                        .HasColumnName("email");
                builder.Property(e => e.Nombre)
                        .HasMaxLength(45)
                        .HasColumnName("nombre");
                builder.Property(e => e.Rol).HasColumnName("rol");
                builder.Property(e => e.Telefono)
                        .HasMaxLength(45)
                        .HasColumnName("telefono");

                builder.HasOne(d => d.RolNavigation).WithMany(p => p.Users)
                        .HasForeignKey(d => d.Rol)
                        .HasConstraintName("rol");
            }
        }
        /*builder.ToTable("User");

        builder.HasKey(a => a.IdUser); // Clave primaria.

        builder.Property(a => a.IdUser)
            .IsRequired()
            .HasColumnName("idUser") // Nombre de la columna en la base de datos MySQL.
            .HasColumnType("int") //Indica el tipo de dato de la columna en MySql.
            .UseMySQLAutoIncrementColumn("idUser");// Indica que es una columna de identidad en MySQL.

        builder.Property(a => a.Nombre)
            .HasColumnName("nombre") // Nombre de la columna en la base de datos MySQL.
            .HasColumnType("varchar") //Indica el tipo de dato de la columna en MySql.
            .HasMaxLength(45)
            .IsRequired();*/

    }
}
