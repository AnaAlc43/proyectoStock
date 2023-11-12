using System.Collections.Generic;
using Stock.BusinessRules.DTOs.ValidationErrorDTO;

namespace Stock.BusinessRules.Interfaces.ValidationSpecification
{
    //Cuando "T" sea una clase
    //Valida el objeto según la especificación y devuelve una lista de errores de validación.
    //Una lista de errores de validación. Si la validación es exitosa, la lista estará vacía

    public interface ISpecification<T> where T : class
    {
        List<ValidationErrorDTOs> IsValid();
    }
}
