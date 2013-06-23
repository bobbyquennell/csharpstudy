using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6PoolPuzzle
{
    class Boat
    {
        private int length;
        public void setlength(int len) 
        {
            length = len;
        }
        public int getLength() 
        {
            return length;
        }
        public virtual string move()
        {
            return "drift ";
        }
    }
}
