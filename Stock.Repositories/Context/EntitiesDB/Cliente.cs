using System;
using System.Collections.Generic;

namespace Stock.Repositories.Context;

public partial class Cliente
{
    public int Idcliente { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? DniCuil { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public int? Telefono { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
