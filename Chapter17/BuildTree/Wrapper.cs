using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTree
{
    class Wrapper<T> : IWrapper<T>
    {
        private T StoredData;        
        
        T IWrapper<T>.GetData()
        {
            return StoredData;
        }
        void IWrapper<T>.SetData(T data)
        {
            this.StoredData = data;
        }
    }
}
