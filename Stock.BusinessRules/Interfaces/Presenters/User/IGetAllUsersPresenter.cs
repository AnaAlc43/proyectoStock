﻿using Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Presenters.UserPresenters
{
    // Este presenter se encarga de manejar la presentación después de recuperar una 
    // lista de todos los Users disponibles en el contexto. 

    public interface IGetAllUsersPresenter : IGetAllUsersOutputPort
    {
        // Propiedad Actors que contiene la colección de objetos ActorResponse
        // que representan a todos los actores.

        WSelectAllUsers Users { get; }
    }
}