using Stock.BusinessRules.Interfaces.Presenters.User;
using Stock.BusinessRules.Wrappers.User;

namespace VideoClub_Presenters.User
{
    public class CreateUserPresenter : ICreateUserPresenter
    {
        public WCreateDeleteUser User { get; private set; } = new WCreateDeleteUser();

        public Task Handle(WCreateDeleteUser user)
        {
            User.ErrorNumber = user.ErrorNumber;
            User.ValidationErrors = user.ValidationErrors;
            User.Message = user.Message;
            User.IdUser = user.IdUser;
            return Task.CompletedTask;
        }
    }
}
