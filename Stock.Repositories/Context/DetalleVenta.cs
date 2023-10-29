using System;
using System.Collections.Generic;

namespace Stock.Repositories.Context;

public partial class DetalleVenta
{
    public int IddetalleVenta { get; set; }

    public int? Producto { get; set; }

    public int? Venta { get; set; }

    public string? PrecioVenta { get; set; }

    public int? Cantidad { get; set; }

    public DateTime? Fecha { get; set; }

    public string? EstadoDetalleVenta { get; set; }

    public virtual Producto? ProductoNavigation { get; set; }

    public virtual Venta? VentaNavigation { get; set; }
}
