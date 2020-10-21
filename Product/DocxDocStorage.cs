using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethod.Product
{
    public class DocxDocStorage : IDocStorage
    {
        public XDocument Load(string name)
        {
            Console.WriteLine("Load Docx");
            return null;
        }

        public void Save(string name, XDocument document)
        {
            Console.WriteLine("Save Docx");
        }
    }
}
