using _00_Library;
using System;
using System.IO;
using System.Xml.Serialization;

namespace _00_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome="Victor",
                CPF="555.555.555-55",
                Email="lkzq33@gmail.com"
            };
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Usuario));
            StreamWriter stream = new StreamWriter(@"C:\Users\victo\OneDrive\Área de Trabalho\MAIN\_01_SerializadorXML.xml");
            xmlSerializer.Serialize(stream, usuario);
        }
    }
}
