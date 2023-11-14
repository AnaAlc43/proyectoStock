using Stock.BusinessRules.Interfaces.Presenters.UserPresenters;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.UserPresenters
{
    public class GetUserByIdPresenter : IGetUserByIdPresenter
    {
        public WSelectUser? User { get; private set; }

        public Task Handle(WSelectUser user)
        {
            User = new WSelectUser
            {
                IdUser = user.IdUser,
                NombreUser = user.NombreUser,
                ErrorNumber = user.ErrorNumber,
                Message = user.Message
            };
            return Task.CompletedTask;
        }
    }
}
