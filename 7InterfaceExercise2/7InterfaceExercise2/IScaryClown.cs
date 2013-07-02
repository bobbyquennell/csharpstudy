using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7InterfaceExercise2
{
    interface IScaryClown:IClown
    {
        string ScaryThingIHave
        { get; }
        void ScareLittleChildren();
    }
}
