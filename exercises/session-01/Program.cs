// AI-generated training starter. Predict before running or changing it.
List<Movie> movies = new List<Movie>
{
    new Movie { Title = "Moon", Price = 8m },
    new Movie { Title = "Arrival", Price = 10m },
    new Movie { Title = "Dune", Price = 12m }
};

PrintTitles(movies);

static void PrintTitles(List<Movie> movies)
{
    foreach (Movie movie in movies)
    {
        Console.WriteLine(movie.Title);
    }
}

static void PrintAffordable(List<Movie> movies, decimal maximum)
{
    foreach (Movie movie in movies)
    {
        if (movie.Price <= maximum)
        {
            Console.WriteLine(movie.Title);
        }
    }
}

class Movie
{
    public string Title { get; set; } = "";
    public decimal Price { get; set; }
}
