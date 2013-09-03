using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7LetsBuildAHouse
{
    class RoomWithDoor:Room, IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
        public RoomWithDoor(string name, string roomDecoration, string doorDescription)
        :base(name,roomDecoration)
        {
            DoorDescription = doorDescription;
        }
    }
}
