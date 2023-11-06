using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.DTOs.ProviderDTOs;
using Stock.BusinessRules.Wrappers.Provider;

namespace Stock.BusinessRules.Interfaces.Controllers.ProviderControllers
{
    public interface IUpdateProviderController
    {
        Task<WCreateDeleteProvider> UpdateProvider(UpdateProviderRequest request);
    }
}
