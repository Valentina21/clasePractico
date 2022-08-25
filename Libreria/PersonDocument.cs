
using System;
namespace Libreria
{
    public class PersonDocument
    {
        public int Personld { get; set; }
        public Person Person { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
    }
}