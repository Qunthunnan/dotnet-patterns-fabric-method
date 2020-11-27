using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethod.Product
{
    public class Fb2DocStorage : IDocStorage
    {
        public string Load(string name)
        {
            if (File.Exists(name + ".fb2"))
            {
                string document;
                StreamReader reader = new StreamReader(name + ".fb2");
                document = reader.ReadToEnd();
                reader.Close();
                return document;
            }
            else
                return "";
        }

        public void Save(string name, string document)
        {
            StreamWriter write = new StreamWriter(name + ".fb2");
            write.Write(document);
            write.Close();
        }
    }
}
