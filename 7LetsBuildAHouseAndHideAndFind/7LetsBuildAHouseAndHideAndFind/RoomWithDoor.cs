using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7LetsBuildAHouseAndHideAndFind
{
    class RoomWithDoor:RoomWithHidingPlace, IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
        public RoomWithDoor(string name, string roomDecoration, string HidingPlaceName, string doorDescription)
        :base(name, roomDecoration, HidingPlaceName)
        {
            DoorDescription = doorDescription;
        }
        public override string Description
        {
            get
            {
                return base.Description + "You can see " + DoorDescription + ", which leads to the " + DoorLocation.Name +
                    "\r\n";
            }
        }
    }
}
