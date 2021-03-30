using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIterators
{
    class BasicCollection<T> : IEnumerable<T>
    {
        List<T> data = null;

        public BasicCollection()
        {
            data = new List<T>();
        }
        public void Fill(params T[] collection)
        {
            foreach (var item in collection)
            {
                data.Add(item);
            }
        }

        public IEnumerable<T> Revers
        {
            get
            {
                for (int i = data.Count - 1; i >= 0; --i)
                {
                    yield return data[i];
                }
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            foreach (var item in data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
