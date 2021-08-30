using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_4
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _raiting;

        public Movie(string title, string studio, string raiting)
        {
            _title = title;
            _studio = studio;
            _raiting = raiting;
        }

        public string GetMovie()
        {
            return _title;
        }

        public string GetStudio()
        {
            return _studio;
        }
        
        public string GetRaitin()
        {
            return _raiting;
        }
        
        public static Movie[] GetPG(Movie[] collection)
        {
            return collection.Where(x => x._raiting == "PG").ToArray();
        }

        public string PrintMovie()
        {
            return $"'{_title}', the studio '{_studio}' and the raiting '{_raiting}'";
        }
    }
}
