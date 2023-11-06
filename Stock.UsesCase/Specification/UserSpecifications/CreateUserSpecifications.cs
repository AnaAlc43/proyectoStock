﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.DTOs.ValidationErrorDTO;
using VideoClub.BusinessRules.Interfaces.ValidationSpecification;

namespace Stock.UsesCase.Specification.UserSpecifications
{
    public class CreateUserSpecifications : ISpecification<CreateUserRequest>
    {
        readonly CreateUserRequest _entity;
        readonly List<ValidationErrorDTOs> _errors = new List<ValidationErrorDTOs>();
        public CreateUserSpecifications(CreateUserRequest entity)
        {
            _entity = entity;
        }

        public List<ValidationErrorDTOs> IsValid()
        {
            if (string.IsNullOrEmpty(_entity.Nombre))
            {
                _errors.Add(new ValidationErrorDTOs
                {
                    PropertyName = "Nombre Usuario",
                    ErrorName = "El campo no puede ser nulo ni vacío."

                });
            }
            else if (_entity.Nombre.Length > 45)
            {
                _errors.Add(new ValidationErrorDTOs
                {
                    PropertyName = "Nomre Usuario",
                    ErrorName = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }
    }
}
