﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7LetsBuildAHouseAndHideAndFind
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public string HidingPlaceName { get; private set; }
        public OutsideWithHidingPlace(string OutsideName, bool bIsItHot, string HidingPlace)
            : base(OutsideName, bIsItHot)
        {
            this.HidingPlaceName = HidingPlace;
        }
        public override string Description
        {
            get
            {
                return base.Description + " Some one could hide in " + HidingPlaceName + "\r\n";
            }
        }

    }
}
