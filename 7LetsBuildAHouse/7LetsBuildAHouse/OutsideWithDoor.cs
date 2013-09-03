using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7LetsBuildAHouse
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public string DoorDescription
        {
            get;
            private set;
        }
        public Location DoorLocation
        {
            get;
            set;
        }
        public OutsideWithDoor(string Name, bool Hot, string DoorDescription)
            : base(Name, Hot) {
                this.DoorDescription = DoorDescription;
        }
    }
  
}
