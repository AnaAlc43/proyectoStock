﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.COMMON.Entities
{
    public class Provider
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Telefono { get; set; }

        public string Contacto { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }
    }
}
