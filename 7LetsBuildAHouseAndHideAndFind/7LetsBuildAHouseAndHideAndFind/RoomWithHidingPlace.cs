using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7LetsBuildAHouseAndHideAndFind
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public string HidingPlaceName { get; private set; }
        public RoomWithHidingPlace(string RoomName, string RoomDecoration, string HidingPlaceName)
            :base(RoomName, RoomDecoration)
       {
           this.HidingPlaceName = HidingPlaceName;
       }

    }
}
