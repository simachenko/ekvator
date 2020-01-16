using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;
namespace BLL.ServicesInterfaces
{
    public interface IDateTimeValidation
    {
        Task<bool> DateTimeValidationAsync(OrderCreationDTO item);
        Task<IEnumerable<OrderCreationDTO>> GetDateTimeOverlayAsync(OrderCreationDTO item);
        bool DateTimeValidation(OrderCreationDTO item);
        bool DateTimeValidation(OrderDTO item);

        IEnumerable<OrderCreationDTO> GetDateTimeOverlay(OrderCreationDTO item);

    }
}
