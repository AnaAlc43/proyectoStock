using Stock.Entities.Entities;
using Stock.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Repositories
{
    //Cuando T sea una clase = Clase es igual a User u otros.
    //En este caso T va a ser Usuario = IRepository<User>
    /*public class UserRepository : IUnitOfWork<User>
    {
        public List<User> Read => throw new NotImplementedException();

        public bool Create(User entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(User originalEntity, User modifiedEntity)
        {
            throw new NotImplementedException();
        }*/
    }
}