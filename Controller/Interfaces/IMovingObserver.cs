﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackMan.Interfaces;

namespace Controller.Interfaces
{
    public interface IMovingObserver
    {
        void Update(IPlayer player);
    }
}
