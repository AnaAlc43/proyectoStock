using Stock.COMMON.Interfaces;
using Stock.COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Repositories
{
    public class ProviderRepository : IRepository<Provider>
    {
        public List<Provider> Read => throw new NotImplementedException();

        public bool Create(Provider entity)
        {
            throw new NotImplementedException();
        }
        public bool Delete(Provider entity)
        {
            throw new NotImplementedException();
        }
        public bool Update(Provider originalEntity, Provider modifiedEntity)
        {
            throw new NotImplementedException();
        }
    }
}
