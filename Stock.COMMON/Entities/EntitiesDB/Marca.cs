using System;
using System.Collections.Generic;

namespace Stock.Repositories.Models;

public partial class Marca
{
    public int Idmarca { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();
}
