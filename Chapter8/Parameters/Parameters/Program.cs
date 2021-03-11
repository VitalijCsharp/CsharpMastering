#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            // TODO:
            WrappedInt Wint = new WrappedInt();
            int i = 0;
            Pass.Value(ref i);
            Console.WriteLine($" i after Pass = {i}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
