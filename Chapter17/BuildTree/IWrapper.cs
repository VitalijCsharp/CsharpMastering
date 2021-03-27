﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTree
{
    interface IWrapper<T>
    {
        void SetData(T data);
        T GetData();
    }
}
