﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badger.Solvers.GameTheory
{
    public class SolvingCompletedEventArgs: EventArgs
    {
        public GameTheorySolution Solution { get; set; }
    }
}
