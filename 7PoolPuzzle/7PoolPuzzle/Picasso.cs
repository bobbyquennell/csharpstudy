using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7PoolPuzzle
{
    class Picasso:Nose
    {
        string face;
        public Picasso(string face) {

            this.face = face;
        }
        public virtual int Ear()
        {
            return 7;
        }

        public virtual string Face
        {
            get { return face; }
        }
    }
}
