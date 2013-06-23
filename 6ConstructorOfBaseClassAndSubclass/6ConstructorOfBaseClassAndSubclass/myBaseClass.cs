using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace _6ConstructorOfBaseClassAndSubclass
{
    class myBaseClass
    {
        public myBaseClass(string baseClassNeedsThis)
        {
            MessageBox.Show("This is the  base class: " + baseClassNeedsThis);
        }
    }
}
