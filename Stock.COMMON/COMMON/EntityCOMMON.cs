using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.COMMON.COMMON
{
    public class EntityCOMMON
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public int UpdateBy { get; set; }
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
        public int Delete { get; set; }
    }
}