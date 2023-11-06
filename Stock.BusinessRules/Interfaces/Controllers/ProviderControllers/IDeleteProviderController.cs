﻿using Stock.BusinessRules.Wrappers.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Controllers.ProviderControllers
{
    public interface IDeleteProviderController
    {
        Task<WDeleteProvider> DeleteProvider(int Id);
    }
}