using System;
using System.Collections.Generic;

namespace Stock.Repositories.Models;

public partial class Producto
{
    public int Idproducto { get; set; }

    public int? Stock { get; set; }

    public string? Nombre { get; set; }

    public string? Lote { get; set; }

    public string? Vencimiento { get; set; }

    public string? Peso { get; set; }

    public string? Imagen { get; set; }

    public string Codigo { get; set; } = null!;

    public string EstadoProd { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Stock? StockNavigation { get; set; }

    public virtual ICollection<Proveedor> IdProveedors { get; set; } = new List<Proveedor>();
}
