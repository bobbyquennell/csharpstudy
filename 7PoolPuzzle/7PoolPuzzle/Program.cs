using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace _7PoolPuzzle
{
    class Program
    {
        static void NotMain(string[] args)
        {
            string result = "";
            Nose[] i = new Nose[3];
            i[0] = new Acts();
            i[1] = new Clowns();
            i[2] = new Of76();
            for (int x = 0; x < 3; x++)
            {
                result += (i[x].Ear() + "" + i[x].Face) + "\n";
            }
            MessageBox.Show(result);
            
        }
    }
}
