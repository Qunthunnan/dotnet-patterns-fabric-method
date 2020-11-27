using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethod.Factory
{
    public abstract class DocumentManager 
    {
        /*1*/

        public abstract IDocStorage CreateStorage();
        public abstract IDocStorage CreateStorage<T>() where T: IDocStorage, new();

        public void Save(string document, String _name)
        {
            // using Factory method to create a new document storage
            IDocStorage storage = this.CreateStorage();

            storage.Save(_name, document);

            //return true;
        }

        /*2*/

        public enum StorageFormat { Fb2, Docx }

        public IDocStorage CreateStorage(StorageFormat format)
        {
            switch (format)
            {
                case StorageFormat.Fb2:
                    return new Fb2DocStorage();

                case StorageFormat.Docx:
                    return new DocxDocStorage();

                default:
                    throw new ArgumentException("An invalid format: " + format.ToString());
            }
        }
    }
}
