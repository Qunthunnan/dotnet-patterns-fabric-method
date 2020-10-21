using System;
using FactoryMethod.Product;

namespace FactoryMethod.Factory
{
    public abstract class DocumentManagerSimpleAdapter : DocumentManager
    {
      public override abstract IDocStorage CreateStorage();
      public override IDocStorage CreateStorage<T>(){
        throw new NotImplementedException();
      }
    }
}