using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7LetsBuildAHouse
{
    interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
}
