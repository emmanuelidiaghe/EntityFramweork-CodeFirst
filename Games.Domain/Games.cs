using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain
{
    public class Game : Entity
    {
        public Game(string title, string genre, int releaseYear, string company)
        {
            Title = title;
            Genre = genre;
            ReleaseYear = releaseYear;
            Company = company;
        }

        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public string Company { get; set; }
    }
}