using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7LetsBuildAHouse
{
    class Room:Location
    {
        private string decoration;
        public string Decoration { get { return decoration;} }
        public Room(string name, string decoration)
            : base(name)
        { 
        
            this.decoration = decoration;
        }
        public override string Description { 
            get {
                string description = "You're standing in the " + base.Name +
                    ". You see exits to the following places: ";
                for (int i = 0; i < base.Exits.Length; i++)
                {
                    description += " " + base.Exits[i].Name;
                    if (i != base.Exits.Length - 1)
                        description += ",";

                }
                description += ".";

                description += " You see " + Decoration.ToString() + " here.";

                return description;

            }  
        }
    }
}
