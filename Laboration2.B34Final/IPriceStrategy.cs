﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2.B34Final
{
    public interface IPriceStrategy
    {
        decimal GetTotal(Order order);
    }
}