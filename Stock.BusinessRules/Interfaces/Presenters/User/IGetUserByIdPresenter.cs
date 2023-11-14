using Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Presenters.UserPresenters
{
    // Este presenter se utiliza para manejar la presentación después de recuperar la
    // información de un User específico por su Id.

    public interface IGetUserByIdPresenter : IGetUserByIdOutputPort
    {
        //  Propiedad User que contiene los detalles del User recuperado.
        WSelectUser User { get; }
    }

}
