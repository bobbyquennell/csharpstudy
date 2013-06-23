using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6ConstructorOfBaseClassAndSubclass
{
    class mySubclass:myBaseClass
    {
        public mySubclass(string baseClassNeedsThis, int anotherValue)
            :base(baseClassNeedsThis)
        {
            MessageBox.Show("This is the subclass:" + baseClassNeedsThis + "and " + anotherValue);
        }
    }
}
