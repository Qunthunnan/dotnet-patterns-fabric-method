using System;
using System.Xml.Linq;
using FactoryMethod.Factory;
using FactoryMethod.Product;

namespace fabric_method
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1*/

            // Save a document as fb2 file using "Save" dialog
            DocumentManager docManager = new Fb2DocumentManager();
            docManager.Save(new XDocument(), "asd.fb2");
            // Or use the IDocStorage interface to save a document
            IDocStorage storage = docManager.CreateStorage();
            storage.Save("asd.fb2", new XDocument());

            /*2*/

            storage =
                docManager.CreateStorage(DocumentManager.StorageFormat.Docx);
            storage.Save("asd.docx", new XDocument());

            /*3*/

            docManager =
                new DocumentManagerGeneric<Fb2DocStorage>();
            storage = docManager.CreateStorage();
            storage.Save("asd.fb2", new XDocument());

            /*4*/
            // инициализация переменной фабрики Fb2-реализацией
            docManager = new DocumentManagerGenericAdapter();
            storage =
                docManager.CreateStorage<DocxDocStorage>();
            storage.Save("asd4.docx", new XDocument());
        }
    }
}
