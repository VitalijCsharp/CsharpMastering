using System;

namespace Parameters
{
    class Pass
    {
        // TODO:
        public static void Value(ref int param)
        {
           param = 42;
        }
        public static void Value(WrappedInt param)
        {
            param.i = 42;
            int? i = null;
            if (!i.HasValue)
            {
                i = 90;
            }
            else
            {
                Console.WriteLine(i.Value);
            }
        }
    }
}
