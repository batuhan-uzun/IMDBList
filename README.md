# IMDb Movie List Application

This is a C# Console Application that allows users to create and manage a list of movies with their respective IMDb scores. The application collects user input and provides filtered outputs based on specific criteria.

## Features

1. **Add Movies**: Users can add movies with their names and IMDb scores.
2. **User-Controlled Loop**: The application asks if the user wants to add more movies after each entry.
3. **View All Movies**: At the end of the program, all movies entered by the user are displayed.
4. **Filter by IMDb Score**: Movies with IMDb scores between 4 and 9 are listed separately.
5. **Filter by Name**: Movies starting with the letter 'A' are displayed with their IMDb scores.

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- Basic understanding of C# programming and console applications.

## How to Run

1. Clone this repository or download the source code.
2. Open the project in your favorite IDE (e.g., Visual Studio, Visual Studio Code).
3. Build and run the application.

### Running the Program

1. Enter the name of a movie when prompted.
2. Provide the IMDb score for the movie (valid range: 0-10).
3. Indicate whether you want to add another movie by typing "Yes" or "No".
4. After choosing "No", the application will:
   - Display all movies.
   - Show movies with IMDb scores between 4 and 9.
   - List movies starting with the letter 'A'.

## Example Usage

Enter the name of the movie: Avatar Enter the IMDb score (between 0 and 10): 8.5 Do you want to add another movie? (Yes/No): Yes Enter the name of the movie: Avengers Enter the IMDb score (between 0 and 10): 9.0 Do you want to add another movie? (Yes/No): No

--- All Movies --- Movie: Avatar, IMDb: 8.5 Movie: Avengers, IMDb: 9.0

--- Movies with IMDb Scores Between 4 and 9 --- Movie: Avatar, IMDb: 8.5

--- Movies Starting with the Letter 'A' --- Movie: Avatar, IMDb: 8.5 Movie: Avengers, IMDb: 9.0

The program has ended. Press any key to exit...


## Project Structure

Program.cs // Contains the main logic of the application
Models/
Movies.cs // Represents the movie object with properties for name and IMDb score


## Contribution

Feel free to fork the repository, make improvements, and submit a pull request. Contributions are always welcome!

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Author

Created by Batuhan Uzun.


