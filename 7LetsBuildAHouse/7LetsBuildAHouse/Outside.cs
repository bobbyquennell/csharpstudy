using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7LetsBuildAHouse
{
    class Outside : Location
    {
        public Boolean Hot { get; private set; }
        public Outside(string name, bool hot)
            : base(name) {
                Hot = hot;        
        }
        public override string Description {
            //get {
            //    string description = "You're standing in the " + base.Name +
            //        ". You see exits to the following places: ";
            //    for (int i = 0; i < base.Exits.Length; i++)
            //    {
            //        description += " " + base.Exits[i].Name;
            //        if (i != base.Exits.Length - 1)
            //            description += ",";

            //    }
            //    description += ".";
            //    if (Hot == true)
            //    {
            //        description += " It's very hot here.";
            //    }

            //    return description;

            //} 
            // a better way: call a method of base class.
            get {
                if (Hot)
                    return base.Description + " It's very hot here.";
                else
                    return base.Description;
            }
        }
    }
}
