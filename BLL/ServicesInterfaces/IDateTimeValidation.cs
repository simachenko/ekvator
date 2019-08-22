using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace BLL.ServicesInterfaces
{
    interface IDateTimeValidation<T>
    {
        Task<bool> DateTimeValidationAsync(T item);
        Task<IEnumerable<T>> GetDateTimeOverlayAsync(T item);
        bool DateTimeValidation(T item);
        IEnumerable<T> GetDateTimeOverlay(T item);

    }
}
