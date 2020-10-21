using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethod.Factory
{
    public class Fb2DocumentManager : DocumentManagerSimpleAdapter
    {
        public override IDocStorage CreateStorage() { return new Fb2DocStorage(); }
    }
}
