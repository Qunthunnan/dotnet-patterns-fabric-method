using System;
using FactoryMethod.Product;

namespace FactoryMethod.Factory
{
    public class DocumentManagerGenericAdapter : DocumentManager
    {
      public override IDocStorage CreateStorage<T>()
      {
        return new T(); 
      }
      public override IDocStorage CreateStorage(){
        throw new NotImplementedException();
      }
    }
}