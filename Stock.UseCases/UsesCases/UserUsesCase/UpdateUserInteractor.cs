using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.DTOs.ValidationErrorDTO;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.BusinessRules.Interfaces.Presenters.User;
using Stock.BusinessRules.Wrappers.User;
using Stock.UseCases.Specification.UserSpecifications;
using Stock.COMMON.Interfaces.Repositories;

namespace Stock.UseCases.UseCases.UserUseCase
{
    public class UpdateUserInteractor : IUpdateUserInputPort
    {
        private readonly IUserRepository _repository;
        private readonly IUpdateUserPresenter _presenter;

        public UpdateUserInteractor(IUserRepository repository, IUpdateUserPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(UpdateUserRequest updateUserRequest)
        {
            List<ValidationErrorDTOs> errors = new List<ValidationErrorDTOs>();
            WUpdateUser userResponse = new();

            try
            {
                //Valida los datos del UserResponse a actualizar.
                errors = ValidateUser(updateUserRequest);

                if (errors.Any())
                {
                    // Manejar el caso en el que el UserResponse no cumpla con las validaciones.
                    // Devuelve un mensaje indicando que los datos del UserResponse no son validos.
                    userResponse.ValidationErrors = errors;
                    await _presenter.Handle(userResponse);
                    return;
                }           
        
                /*
                // Obtener el UserResponse existente por su ID
                // Obtener el UserResponse existente por su ID
                User existingUser = await _repository.GetById(updateUserRequest.Id);
                if (existingUser == null)
                {
                    // Manejar el caso en el que el UserResponse no existe
                    // Devuelve un mensaje indicando que el UserResponse no se encontró.
                    userResponse.ErrorNumber = 404;
                    userResponse.Message = $"El Usuario con {updateUserRequest.Id} no existe";
                    await _presenter.Handle(userResponse);
                    return;
                }
                existingUser = await _repository.GetById(updateUserRequest.Id);

                if (existingUser == null)
                {
                    // Manejar el caso en el que el UserResponse no existe
                    // Devuelve un mensaje indicando que el UserResponse no se encontró.
                    userResponse.ErrorNumber = 404;
                    userResponse.Message = $"El acton con {updateUserRequest.Id} no existe";
                    await _presenter.Handle(userResponse);
                    return;
                }
                
                // Actualizar la información del User con los datos proporcionados
                existingUser.Nombre = updateUserRequest.Nombre;

                // Realizar la actualización en el repositorio
                await _repository.Update(existingUser);
                await _repository.SaveChange();

                // Crear un objeto de respuesta exitosa
                userResponse.IdUser = existingUser.Id;
                userResponse.NombreUsuario = existingUser.Nombre;

                // Enviar la respuesta al presentador
                await _presenter.Handle(userResponse);*/
            }

            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir durante la actualización
                userResponse.Message = ex.Message;
            }
            finally
            {
                await _presenter.Handle(userResponse);
            }
        }
        
        private List<ValidationErrorDTOs> ValidateUser(UpdateUserRequest updateUserRequest)
        {
            var specification = new UpdateUserSpecifications(updateUserRequest);
            return specification.IsValid();
        }
    }
}
