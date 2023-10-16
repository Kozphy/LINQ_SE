using System;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Net.Mime;
using System.Collections.Generic;

namespace Q_basics_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static void ReadXMLFile()
        {
            XmlDocument doc = new XmlDocument();
            string currentWorkingDir = Environment.CurrentDirectory;
            // C:\Users\dbdf0\source\repos\LINQ_SE\Linq_Practice\Q_basics\XMLFile.xml
            string xmlFileName = "XMLFile.xml";
            DirectoryInfo executablePath = new DirectoryInfo(currentWorkingDir).Parent.Parent.Parent;
            string xmlFilePath = Path.Combine(executablePath.ToString(), xmlFileName);
            Console.WriteLine(xmlFilePath);
            doc.Load(xmlFilePath);
            //TODO: fix
            XmlNode nodes = doc.SelectSingleNode("//underline");
            Console.WriteLine(nodes.Value);

            //foreach (XmlNode node in nodes)
            //{
            //    Console.WriteLine(node.Value);
            //}

        }
    }
}