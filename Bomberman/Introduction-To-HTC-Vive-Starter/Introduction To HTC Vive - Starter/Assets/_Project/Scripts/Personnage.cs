using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._Project.Scripts
{
    public abstract class Personnage
    {
        protected int Range { get; set; }
        protected int NbBomb { get; set; }
        protected int PosX { get; set; }
        protected int PosY { get; set; }

    }
}
