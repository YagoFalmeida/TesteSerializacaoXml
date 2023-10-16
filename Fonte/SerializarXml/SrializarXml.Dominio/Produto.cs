using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SrializarXml.Dominio
{
    public class Produto
    {
        public string Nome { get; set; }
        
        public Fabricante Fabricante { get; set; }

        public Produto() 
        {
            Fabricante = new Fabricante();
        }
    }
}
