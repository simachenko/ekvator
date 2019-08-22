using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class AccessType
    {
        public int AccesTypeId { set; get; }

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
