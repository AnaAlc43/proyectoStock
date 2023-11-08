using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.COMMON.Interfaces
{
    public interface IUnitOfWork
    {    
        Task SaveChange();
    }
}