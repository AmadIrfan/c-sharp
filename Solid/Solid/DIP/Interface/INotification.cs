﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP
{
    internal interface INotification
    {
        void sendNotification(String message);
    }
}