
using System.Threading.Tasks;
using Stock.BusinessRules.Wrappers.Provider;

namespace Stock.BusinessRules.Interfaces.Getways.ProviderGetways.OutputPort
{
    // Este Output Port se encarga de manejar la respuesta o salida
    // después de eliminar un proveedor.

    public interface IDeleteProviderOutputPort
    {
        /// <summary>
        /// Maneja la respuesta que se le envía al Presenter con los detalles de la operación
        /// de Eliminación de un Provider en el contexto.
        /// </summary>
        /// <param name="idProvider">Recibir el Id del Provider que se eliminó</param>
        Task Handle(WDeleteProvider provider);
    }

}
