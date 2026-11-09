// AI-generated harness; method assembled from Ted's attempts and corrections.
List<Movie> movies = new List<Movie>
{
    new Movie { Title = "Moon", Price = 12m },
    new Movie { Title = "Arrival", Price = 8m },
    new Movie { Title = "Dune", Price = 8m },
    new Movie { Title = "Alien", Price = 6m }
};

Movie? result = FindCheapest(movies, 10m);
if (result == null)
{
    Console.WriteLine("No qualifying movie");
}
else
{
    Console.WriteLine(result.Title + ": " + result.Price);
}

static Movie? FindCheapest(List<Movie> movies, decimal maximum)
{
    Movie? lowest = null;
    foreach (Movie movie in movies)
    {
        if (movie.Price <= maximum)
        {
            if (lowest == null || movie.Price < lowest.Price)
            {
                lowest = movie;
            }
        }
    }
    return lowest;
}

class Movie
{
    public string Title { get; set; } = "";
    public decimal Price { get; set; }
}

