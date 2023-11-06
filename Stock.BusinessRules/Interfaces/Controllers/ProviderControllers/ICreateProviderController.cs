using Stock.BusinessRules.DTOs.ProviderDTOs;
using Stock.BusinessRules.Wrappers.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Controllers.ProviderControllers
{
    public interface ICreateProviderController
    {
        Task<WCreateDeleteProvider> CreateProvider (CreateProviderRequest request);
    }
}
