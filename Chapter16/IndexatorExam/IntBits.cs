using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorExam
{
    class IntBits
    {
        private int _bytes;
        public IntBits(int item)
        {
            _bytes = item;
        }
        public int Bytes
        {
            get { return _bytes; }
        }

        public bool this[int index]
        {
            get => (_bytes & (1 << index)) != 0;
            set
            {
                if (value)
                {
                    _bytes |= (1 << index);
                }
                else
                {
                    _bytes &= ~(1 << index);
                }
            }
        }
    }
}
