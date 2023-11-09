using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.COMMON.Interfaces
{
    public interface IUnitOfWork
    //La interfaz "IUnitOfWork" define un contrato para un objeto de unidad de trabajo.
    // todas ellas se ejecutan correctamente o ninguna se ejecuta en caso de error.

    //La propiedad "SaveChange" es un método asíncrono que guarda los cambios realizados en la unidad de trabajo.
    {
        Task SaveChange();
    }
}