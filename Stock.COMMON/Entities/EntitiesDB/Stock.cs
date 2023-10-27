using System;
using System.Collections.Generic;

namespace Stock.Repositories.Models;

public partial class Stock
{
    public int IdStock { get; set; }

    public int? Marca { get; set; }

    public int? Categoria { get; set; }

    public string? Nombre { get; set; }

    public string EstadoStock { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual Categoria? CategoriaNavigation { get; set; }

    public virtual Marca? MarcaNavigation { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
