using Stock.BusinessRules.Interfaces.Presenters.UserPresenters;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.Presenters.UserPresenters
{
    public class GetAllUserPresenter : IGetAllUsersPresenter
    {
        public WSelectAllUsers Users { get; private set; }

        public ValueTask Handle(WSelectAllUsers users)
        {
            Users = users;
            return ValueTask.CompletedTask;
        }
    }
}
