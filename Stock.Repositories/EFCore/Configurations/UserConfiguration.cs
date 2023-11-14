using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.EntityFrameworkCore.Extensions;
using Stock.COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Repositories.EFCore.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(a => a.Id); // Clave primaria.

            builder.Property(a => a.Id)
                .IsRequired()
                .HasColumnName("idUsuario") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") //Indica el tipo de dato de la columna en MySql.
                .UseMySQLAutoIncrementColumn("idUsuario");// Indica que es una columna de identidad en MySQL.

            builder.Property(a => a.Nombre)
                .HasColumnName("nombreUsuario") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") //Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(45)
                .IsRequired();
        }
    }
}
