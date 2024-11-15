using IMDBList.Models;

List<Movies> movieList = new List<Movies>();
string userInput;

do
{
    // Prompt the user to enter the movie name
    Console.WriteLine("Enter the name of the movie:");
    string movieName = Console.ReadLine();

    // Prompt the user to enter the IMDb score
    Console.WriteLine("Enter the IMDb score (between 0 and 10):");
    double imdbScore;
    while (!double.TryParse(Console.ReadLine(), out imdbScore) || imdbScore < 0 || imdbScore > 10)
    {
        // Validate the IMDb score input
        Console.WriteLine("Please enter a valid IMDb score (between 0 and 10):");
    }

    // Create a new movie object and add it to the list
    movieList.Add(new Movies { MovieNames = movieName, Imdb = imdbScore });

    // Ask the user if they want to add another movie
    Console.WriteLine("Do you want to add another movie? (Yes/No):");
    userInput = Console.ReadLine()?.Trim().ToLower();

} while (userInput == "yes");

// Display all movies
Console.WriteLine("\n--- All Movies ---");
foreach (var movie in movieList)
{
    Console.WriteLine($"Movie: {movie.MovieNames}, IMDb: {movie.Imdb}");
}

// Display movies with IMDb scores between 4 and 9
Console.WriteLine("\n--- Movies with IMDb Scores Between 4 and 9 ---");
var filteredMovies = movieList.Where(m => m.Imdb >= 4 && m.Imdb <= 9).ToList();
foreach (var movie in filteredMovies)
{
    Console.WriteLine($"Movie: {movie.MovieNames}, IMDb: {movie.Imdb}");
}

// Display movies that start with the letter 'A'
Console.WriteLine("\n--- Movies Starting with the Letter 'A' ---");
var moviesStartingWithA = movieList.Where(m => m.MovieNames.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
foreach (var movie in moviesStartingWithA)
{
    Console.WriteLine($"Movie: {movie.MovieNames}, IMDb: {movie.Imdb}");
}

// End the program
Console.WriteLine("\nThe program has ended. Press any key to exit...");
Console.ReadKey();