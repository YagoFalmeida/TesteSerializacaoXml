using SrializarXml.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializarXml
{
    public class Program
    {
        static void Main(string[] args)
        {
            SerializarParaXml();
        }

        public static void SerializarParaXml()
        {
            Produto produto = new Produto();
            produto.Nome = "Biscoito";
            produto.Fabricante.Nome = "Mabel";
            XmlSerializer xml = new XmlSerializer(typeof(Produto));
            TextWriter writer = new StreamWriter("E:\\Testes\\Xml\\Produto.xml");
            xml.Serialize(writer, produto);
        }
    }
}
