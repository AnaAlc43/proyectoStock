using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.DTOs.ValidationErrorDTO;
using Stock.BusinessRules.Interfaces.ValidationSpecification;


namespace Stock.UseCases.Specification.UserSpecifications
{
    public class UpdateUserSpecifications : ISpecification<UpdateUserRequest>
    {
        readonly UpdateUserRequest _entity;
        readonly List<ValidationErrorDTOs> _errors = new();

        public UpdateUserSpecifications(UpdateUserRequest entity)
        {
            _entity = entity;
        }

        public List<ValidationErrorDTOs> IsValid()
        {
            if (_entity.IdUser == 0)
            {
                _errors.Add(new ValidationErrorDTOs()
                {
                    PropertyName = "Id",
                    ErrorMessage = "Debe especficar el Id que desea actualizar"
                });
            }

            if (string.IsNullOrEmpty(_entity.Nombre))
            {
                _errors.Add(new ValidationErrorDTOs
                {
                    PropertyName = "Nombre Usuario",
                    ErrorMessage = "El campo no puede ser nulo ni vacío."

                });
            }
            if (!string.IsNullOrEmpty(_entity.Nombre) && _entity.Nombre.Length > 45)
            {
                _errors.Add(new ValidationErrorDTOs
                {
                    PropertyName = "Nombre Usuario",
                    ErrorMessage = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }
    }
}
