using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Director(int id, string name, string birthDate, string birthPlace)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            BirthPlace = birthPlace;
        }
    }
}
