using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace GarbageCollectionDemo
{
    class AvtoGenDispose : IDisposable
    {
        private bool disposedValue;
        private StringReader textReader;
        private Application excel;
        public AvtoGenDispose()
        {
            textReader = new StringReader(" ");
            excel = new Application();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    if(textReader != null)
                    {
                        textReader.Dispose();
                        textReader = null;
                    }
                }

                if(excel != null)
                {
                    excel.Quit();
                    Marshal.ReleaseComObject(excel);
                    excel = null;
                }
                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~AvtoGenDispose()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
