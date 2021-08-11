using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _movies;

        public object Vidoe { get; private set; }

        public VideoStore()
        {
            _movies = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _movies.Add(item: new Video(title));
        }
        
        public void Checkout(string title)
        {
            var movie = FIndAMovieByTitle(title);
            movie.BeingCheckedOut();    
        }

        public void ReturnVideo(string title)
        {
            var movie = FIndAMovieByTitle(title);
            movie.BeingReturned();         
        }

        public void TakeUsersRating(double rating, string title)
        {
            var movie = FIndAMovieByTitle(title);
                movie.ReceivingRating(rating);
        }

        public void ListInventory()
        {
            foreach(var movie in _movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }

        private Video FIndAMovieByTitle(string title)
        {
            foreach (var movie in _movies)
            {
                if (movie.Title != title) continue;
                return movie;
            }
            return null;
        }
    }
}
