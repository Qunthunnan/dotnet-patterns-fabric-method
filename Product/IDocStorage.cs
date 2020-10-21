using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethod.Product
{
    public interface IDocStorage
    {
        void Save(string name, XDocument document);
        XDocument Load(string name);
    }
}
