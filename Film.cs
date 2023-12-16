using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreationYear { get; set; }
        public string Style { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public Film(int id, string name, int creationYear, string style, int director_id)
        {
            Id = id;
            Name = name;
            CreationYear = creationYear;
            Style = style;
            DirectorId = director_id;
        }
    }
}
