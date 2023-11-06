﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Presenters.User
{
    /// <summary>
    /// Este presenter se encarga de manejar la presentación después de insertar 
    /// un nuevo registro de un User en el contexto.
    /// </summary>
    public interface ICreateUserPresenter : ICreateUserOutputPort
    {
        /// <summary>
        /// Expone una propiedad User que contiene detalles sobre la operación
        /// de inserción.
        /// </summary>
        WCreateDeleteUser User { get; }
    }
}
