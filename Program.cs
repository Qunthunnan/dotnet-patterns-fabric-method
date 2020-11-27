using System;
using System.Collections.Generic;
using System.Threading;
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
            List<string> menuChoises = new List<string>() { "Создать", "Открыть", /*"Сохранить", "Сохранить под новым именем",*/ "Закрыть" };
            List<string> formatChoises = new List<string>() { "FB2", "DOCX" };
            string docname;
            string document="";
            Menu mainMenu = new Menu(0, 0, menuChoises);
            bool exit = false;

            while (!exit)
            {
                switch (mainMenu.navigate())
                {
                    case 0:
                        Console.Write("Введите имя документа: ");
                        docname = Console.ReadLine();
                        Console.Clear();
                        switch (new Menu(0,0,formatChoises).navigate())
                        {
                            case 0:
                                new Fb2DocStorage().Save(docname, "");
                                break;
                            case 1:
                                new DocxDocStorage().Save(docname, "");
                                break;
                            default:
                                break;
                        }
                        break;

                    case 1:
                        bool exitDocument = false;
                        Console.Write("Введите имя документа: ");
                        docname = Console.ReadLine();
                        DocumentManager.StorageFormat format;
                        Console.Clear();
                        switch (new Menu(0, 0, formatChoises).navigate())
                        {
                            case 0:
                                document = new Fb2DocStorage().Load(docname);
                                format = DocumentManager.StorageFormat.Fb2;
                                break;
                            case 1:
                                document = new DocxDocStorage().Load(docname);
                                format = DocumentManager.StorageFormat.Docx;
                                break;
                            default:
                                format = DocumentManager.StorageFormat.Fb2;
                                break;
                        }

                        while (!exitDocument)
                        {
                            
                            List<string> editMenu = new List<string>() { "Дополнить документ", "Сохранить", "Сохранить под новым именем","Закрыть документ" };
                            Console.WriteLine(document);
                            
                            switch (new Menu(0, Console.WindowHeight - 3, editMenu).navigate())
                            {
                                case 0:
                                    Console.Write("Дополненение документа: ");
                                    document += Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 1:
                                    if (format == DocumentManager.StorageFormat.Fb2)
                                    {
                                        new Fb2DocStorage().Save(docname, document);
                                    }
                                    else
                                    {
                                        new DocxDocStorage().Save(docname, document);
                                    }
                                    Console.WriteLine("Сохранено!");
                                    Console.Read();
                                    Console.Clear();
                                    break;

                                case 2:
                                    Console.Write("Введите новое имя документа: ");
                                    docname = Console.ReadLine();
                                    Console.Clear();
                                    if (format == DocumentManager.StorageFormat.Fb2)
                                    {
                                        new Fb2DocStorage().Save(docname, document);
                                    }
                                    else
                                    {
                                        new DocxDocStorage().Save(docname, document);
                                    }
                                    Console.WriteLine("Сохранено!");
                                    Console.Read();
                                    Console.Clear();
                                    break;

                                case 3:
                                    Console.Clear();
                                    exitDocument = true;
                                    break;
                                default:
                                    break;
                            }                   
                        }

                        break;

                    case 2:
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
