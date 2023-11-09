using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.COMMON.Common
{
    //"EntityCommon" permite a las entidades de negocio compartir estas propiedades comunes de forma fácil y eficiente.
    public class EntityCommon
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
