using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethod.Product
{
    public class Fb2DocStorage : IDocStorage
    {
        public XDocument Load(string name)
        {
            Console.WriteLine("Load Fb2");
            return null;
        }

        public void Save(string name, XDocument document)
        {
            Console.WriteLine("Save Fb2");
        }
    }
}
