using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.collections
{
    public class MovieLibrary
    { 
        IList<Movie> movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            this.movies = list_of_movies;
        }

        public IEnumerable<Movie> all_movies()
        { // original
          // return movies;
            foreach (var movie in movies) yield return movie;
           
        }

        public void add(Movie movie)
        {
            if (movies.Contains(movie))
                return;
            
            foreach (var m in movies )

            {
                if (m.title == movie.title)
                    return;
            }
            movies.Add(movie);
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending
        {
            get { throw new NotImplementedException(); }
            
        }

        public IEnumerable<Movie> all_movies_published_by_pixar()
        {
            foreach (var mx in movies)
                if (mx.production_studio == ProductionStudio.Pixar)
                    yield return mx;
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            foreach (var mx in movies)
                if ((mx.production_studio == ProductionStudio.Pixar) ||
            (mx.production_studio == ProductionStudio.Disney))
                    yield return mx;
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_action_movies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
        {
            throw new NotImplementedException();
        }
    }
}