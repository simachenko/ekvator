﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    public class RoomCreationDTO
    {
        public RoomCreationDTO(int number, int floor, DateTime startExpluatation, DateTime endExpluatation)
        {
            Number = number;
            Floor = floor;
            StartExpluatation = startExpluatation;
            EndExpluatation = endExpluatation;
        }

        public int Number { set; get; }
        public int Floor { set; get; }
        public DateTime StartExpluatation { set; get; }
        public DateTime EndExpluatation { set; get; }
    }
}
