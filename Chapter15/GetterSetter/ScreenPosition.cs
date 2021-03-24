using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    struct ScreenPosition
    {
        private int _x, _y;
        public ScreenPosition(int X, int Y)
        {
            _x = rangeChaeckedX(X);
            _y = rangeChaeckedY(Y);
        }
        private static int rangeChaeckedX(int X)
        {
            if(X >= 0 && X <= 1280)
            {
                return X;
            }

            return 0;
        }
        private static int rangeChaeckedY(int Y)
        {
            if (Y >= 0 && Y <= 1440)
            {
                return Y;
            }

            return 0;
        }

        public int X
        {
            get => _x;
            set
            {
                _x = rangeChaeckedX(value);
            }
        }
        public int Y
        {
            get => _y;
            set
            {
                _y = rangeChaeckedY(value);
            }
        }

        //private int x;
        //private int y;

        //public int Y 
        //{
        //    get => y;
        //    set 
        //    { 
        //        if(value >=0 && value <= 1280)
        //        {
        //            y = value;
        //        }
        //    } 
        //}
        //public int X { get => x; set => x = value; }
    }
}
