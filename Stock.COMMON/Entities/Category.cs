using System;
using System.Collections.Generic;

namespace Stock.COMMON.Entities
{
    public partial class Category
    {
        public int IdCategory { get; set; } //Es el identificador único de la categoría. 

        public string Nombre { get; set; } //nombre de la categoría, como "Electrónica", "Ropa", etc.

        public string Descripcion { get; set; } //Es una descripción detallada de la categoría.

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        //define una propiedad llamada "Products" en la clase "Category". La propiedad "Products"
        //es de tipo "ICollection<Product>" que es una interfaz genérica en C# que representa una colección de objetos.
    }
}