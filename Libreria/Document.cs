using  System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace Libreria;

    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public List<PersonDocument> Personsdocuments { get; set; }
    }
