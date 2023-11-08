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
    /// <summary>
    /// Clase que implementa el Input Port para crear un UserResponse.
    /// </summary>
    public class CreateUserIteractor : ICreateUserInputPort
    {
        readonly IUserRepository _repository;
        readonly ICreateUserPresenter _presenter;

        /// <summary>
        /// Constructor de la clase CreateUserIteractor.
        /// </summary>
        /// <param name="repository">El repositorio de Usuarios.</param>
        /// <param name="presenter">El presentador para la creación de Usuarios.</param>
        public CreateUserIteractor(IUserRepository repository, ICreateUserPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        /// <summary>
        /// Maneja la creación de un nuevo UserResponse.
        /// </summary>
        /// <param name="createUserRequest">Los datos para crear el UserResponse.</param>
        /// <returns>El ID del nuevo UserResponse creado o 0 si hubo errores.</returns>
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
