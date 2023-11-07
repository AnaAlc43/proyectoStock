using Stock.BusinessRules.Interfaces.Presenters.User;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.Presenters.User
{
    public class DeleteUserPresenter : IDeleteUserPresenter
    {
        public WDeleteUser User { get; private set; } = new WDeleteUser();

        public Task Handle(WDeleteUser user)
        {
            User.ErrorNumber = user.ErrorNumber;
            User.Message = user.Message;
            User.IdUser = user.IdUser;
            return Task.CompletedTask;
        }
    }
}
