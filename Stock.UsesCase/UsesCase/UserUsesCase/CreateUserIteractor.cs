using Stock.COMMON.Entities;
using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.DTOs.ValidationErrorDTO;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.BusinessRules.Interfaces.Presenters.User;
using Stock.BusinessRules.Wrappers.User;
using Stock.UsesCase.Specification.UserSpecifications;
using Stock.COMMON.Interfaces.Repositories;

namespace Stock.UseCases.Specification.UserSpecifications
{
    public class CreateUserIteractor : ICreateUserInputPort
    {
        readonly IUserRepository _repository;
        readonly ICreateUserPresenter _presenter;

        public CreateUserIteractor(IUserRepository repository, ICreateUserPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(CreateUserRequest creatUserRequest)
        {
            List<ValidationErrorDTOs> errors = new List<ValidationErrorDTOs>();
            errors = ValidateUser(creatUserRequest);
            WCreateDeleteUser userResponse = new();

            if (errors.Any())
            {
                userResponse.ValidationErrors = errors;
                await _presenter.Handle(userResponse);
                return;
            }

            User newUser = new()
            {
                Nombre = creatUserRequest.Nombre
            };

            try
            {
                await _repository.Create(newUser);
                await _repository.SaveChange();
                userResponse.IdUser = newUser.IdUser;
            }
            catch (Exception ex)
            {
                userResponse.ErrorNumber = 500;
                userResponse.Message = $"Se produjo un error al guardar los datos. {ex.Message}";
            }
            finally
            {
                await _presenter.Handle(userResponse);
            }
        }

        private List<ValidationErrorDTOs> ValidateUser(CreateUserRequest creatUserRequest)
        {
            var specification = new CreateUserSpecifications(creatUserRequest);
            return specification.IsValid();
        }
    }
}
