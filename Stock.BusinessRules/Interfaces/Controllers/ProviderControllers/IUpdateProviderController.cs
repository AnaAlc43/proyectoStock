using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Controllers.ProviderControllers
{
    public interface IUpdateProviderController
    {
        Task<WCreateDeleteProvider> UpdateProvider(UpdateProviderRequest request);
    }
}
