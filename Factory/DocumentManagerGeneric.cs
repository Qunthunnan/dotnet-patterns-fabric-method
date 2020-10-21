using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    /*3*/
    public class DocumentManagerGeneric<T> : DocumentManagerSimpleAdapter where T : IDocStorage, new()
    {
        public override IDocStorage CreateStorage()
        {
            IDocStorage storage = new T();
            //do something else...
            return storage;
        }
    }
}
