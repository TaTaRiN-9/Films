using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class OrdinaryUser : User
    {
        public int Id { get; set; }
        public OrdinaryUser(int id)
        {
            Id = id;
        }
        public addNewFilm addNewFilm()
        {
            return new addNewFilm(Id);
        }

        public addNewDirector addNewDirector()
        {
            return new addNewDirector(Id);
        }

        public updateFilm updateFilm(Film film)
        {
            return new updateFilm(film);
        }

        public updateDirector updateDirector(Director director)
        {
            return new updateDirector(director);
        }
    }
}
