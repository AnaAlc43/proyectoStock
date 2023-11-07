using Stock.BusinessRules.Interfaces.Presenters.User;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.Presenters.User
{
    public class UpdateUserPresenter : IUpdateUserPresenter
    {
        public WUpdateUser User => throw new NotImplementedException();

        public Task Handle(WUpdateUser user)
        {
            throw new NotImplementedException();
        }
    }
}
