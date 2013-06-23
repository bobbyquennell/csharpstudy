using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6PoolPuzzle
{
    class TestBoat
    {
        public static void Main() 
        {
            string xyz = "";
            Boat b1 = new Boat();
            Sailboat b2 = new Sailboat();
            Rowboat b3 = new Rowboat();
            b2.setlength(32);
            xyz = b1.move();
            xyz += b3.move();
            xyz += b2.move();
            System.Windows.Forms.MessageBox.Show(xyz);
        }
    }
}
