using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    public class OrderDateValidationDTO
    {
        public OrderDateValidationDTO( DateTime arrival, DateTime departure)
        {
            Arrival = arrival;
            Departure = departure;

        }
        public DateTime Arrival { set; get; }
        public DateTime Departure { set; get; }
    }
}
