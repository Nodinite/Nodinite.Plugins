using System;
using System.Collections.Generic;

namespace Nodinite.Plugins.Core.Models
{
    public class DisposableList<T> : List<T>, IDisposable where T : IDisposable
    {
        public void Dispose()
        {
            foreach (T obj in this)
            {
                try
                {
                    obj.Dispose();
                }
                catch
                {

                }
            }
            GC.SuppressFinalize(this);
        }
    }
}
