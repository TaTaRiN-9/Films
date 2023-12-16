using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    interface User
    {
        int Id { get; set; }

        addNewFilm addNewFilm();

        updateFilm updateFilm(Film film);

        addNewDirector addNewDirector();

        updateDirector updateDirector(Director director);
    }
}
