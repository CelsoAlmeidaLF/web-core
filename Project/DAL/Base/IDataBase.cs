﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface IDataBase<T>
    {
        IEnumerable<T> GetList();
        T Get();
        bool Set();
        T SetObject(object obj);
        bool Del();
    }
}
