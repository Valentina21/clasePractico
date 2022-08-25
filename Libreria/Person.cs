using System;
using  System.Collections.Generic;
namespace Libreria
{
    // Creo la clase Person
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<PersonDocument> Personsdocuments { get; set; }
    }
}