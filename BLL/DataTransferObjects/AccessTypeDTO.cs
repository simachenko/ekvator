using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    public class AccessTypeDTO
    {
        public AccessTypeDTO(bool accountR, bool accountW, bool accountX, bool clientR, bool clientW, bool clientX, bool eventR, bool eventW, bool eventX, bool orderR, bool orderW, bool orderX, bool roomR, bool roomW, bool roomX, bool accessTypeR, bool accessTypeW, bool accessTypeX)
        {
            AccountR = accountR;
            AccountW = accountW;
            AccountX = accountX;
            ClientR = clientR;
            ClientW = clientW;
            ClientX = clientX;
            EventR = eventR;
            EventW = eventW;
            EventX = eventX;
            OrderR = orderR;
            OrderW = orderW;
            OrderX = orderX;
            RoomR = roomR;
            RoomW = roomW;
            RoomX = roomX;
            AccessTypeR = accessTypeR;
            AccessTypeW = accessTypeW;
            AccessTypeX = accessTypeX;
        }

        public bool AccountR { set; get; }
        public bool AccountW { set; get; }
        public bool AccountX { set; get; }
        public bool ClientR { set; get; }
        public bool ClientW { set; get; }
        public bool ClientX { set; get; }
        public bool EventR { set; get; }
        public bool EventW { set; get; }
        public bool EventX { set; get; }
        public bool OrderR { set; get; }
        public bool OrderW { set; get; }
        public bool OrderX { set; get; }
        public bool RoomR { set; get; }
        public bool RoomW { set; get; }
        public bool RoomX { set; get; }
        public bool AccessTypeR { set; get; }
        public bool AccessTypeW { set; get; }
        public bool AccessTypeX { set; get; }
    }
}
