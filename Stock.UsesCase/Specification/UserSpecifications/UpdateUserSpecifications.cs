using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.DTOs.ValidationErrorDTO;
using VideoClub.BusinessRules.Interfaces.ValidationSpecification;


namespace Stock.UsesCase.Specification.UserSpecifications
{
    public class UpdateUserSpecifications : ISpecification<UpdateUserRequest>
    {
        readonly UpdateUserRequest _entity;
        readonly List<ValidationErrorDTOs> _errors = new List<ValidationErrorDTOs>();

        public UpdateUserSpecifications(UpdateUserRequest entity)
        {
            _entity = entity;
        }

        public List<ValidationErrorDTOs> IsValid()
        {
            if (_entity.Id == 0)
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
                    PropertyName = "Nomre Actor",
                    ErrorMessage = "El campo no puede ser nulo ni vacío."

                });
            }
            if (!string.IsNullOrEmpty(_entity.Nombre) && _entity.Nombre.Length > 45)
            {
                _errors.Add(new ValidationErrorDTOs
                {
                    PropertyName = "Nomre Actor",
                    ErrorMessage = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }
    }
}
