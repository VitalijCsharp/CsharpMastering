using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Calculator : IDisposable
    {
        private bool disposed = false;

        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }
        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }
        public int Divide(int first, int second)
        {
            return first / second;
        }

        public void Dispose()
        {
            if (!this.disposed)
            {
                Console.WriteLine("Calculator being disposed"); 
            }
            this.disposed = true;
            //this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        //protected virtual void Dispose(bool disposing)
        //{
        //    if(!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //           // TODO: fdfdd
        //        }
        //        // TODO: erere
        //        this.disposed = true;
        //    }
        //}
    }
}
