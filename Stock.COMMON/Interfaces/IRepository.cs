﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.COMMON.Interfaces
{
    public interface IRepository<T> where T : class
        //Este repositorio va a ser de tipo "T" -> TIPO donde esta T hereda de una clase no especificada.
        //Cuando T sea una clase
    {
        bool Create(T entity);
        bool Update(T originalEntity, T modifiedEntity);
        bool Delete(T entity);
        List<T> Read { get; }
    }
}