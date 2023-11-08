using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.Wrappers;

namespace Stock.BusinessRules.Wrappers.Provider
{
    //La clase WDeleteProviderhereda de la clase WBase.
    //Esta herencia significa que WDeleteProviderpuede utilizar todas las propiedades y 
    //métodos que WBase  tiene,a menos que estén marcados como private en WBase.
    public class WDeleteProvider : WBase
    {
        public int IdProvider { get; set; }
    }
}
