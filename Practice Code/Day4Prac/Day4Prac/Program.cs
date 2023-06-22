// See https://aka.ms/new-console-template for more information
using Day4Prac;

Console.WriteLine("Hello, World!");

#region Movies
// This sets the strings from the class into data
Movie firstmovie = new Movie();
firstmovie.MovieTitle = "House IV";
firstmovie.MovieReleaseStatus = true;
firstmovie.MovieGenre = "Horror";

// This sets out the output from the class
string firstmoviestuff = $"The name of the movie is {firstmovie.MovieTitle}" +
    $" and its genre is {firstmovie.MovieGenre}. " +
    $"The current status of releasing of this movie is {firstmovie.MovieReleaseStatus}";

// This outputs the string
Console.WriteLine(firstmoviestuff);

Movie secondmovie = new Movie();
secondmovie.MovieTitle = "The FLash";
secondmovie.MovieReleaseStatus = true;
secondmovie.MovieGenre = "Superhero";

string secondmoviestuff = $"The name of the movie is {secondmovie.MovieTitle}" +
    $" and its genre is {secondmovie.MovieGenre}. " +
    $"The current status of releasing of this movie is {secondmovie.MovieReleaseStatus}";

Console.WriteLine(secondmoviestuff);

Movie thirdmovie = new Movie();
thirdmovie.MovieTitle = "The Road";
thirdmovie.MovieReleaseStatus = true;
thirdmovie.MovieGenre = "Dystopia";

string thirdmoviestuff = $"The name of the movie is {thirdmovie.MovieTitle}" +
    $" and its genre is {thirdmovie.MovieGenre}. " +
    $"The current status of releasing of this movie is {thirdmovie.MovieReleaseStatus}";

Console.WriteLine(thirdmoviestuff);
#endregion

#region VideoGames
VideoGame firstvideogame = new VideoGame();
firstvideogame.NameOfVideoGame = "Minecraft";
firstvideogame.TypeOfVideoGame = "Online Educational Sandbox";
firstvideogame.TypeOfDevice = "IPhone, IPad, Xbox, PS, PC, Android";
firstvideogame.Multiplayer = true;

string list1 = $"{firstvideogame.NameOfVideoGame}, {firstvideogame.TypeOfVideoGame}, {firstvideogame.TypeOfDevice}, {firstvideogame.Multiplayer}";
Console.WriteLine("Name Of Video Game, Type of Video Game, Type of Device, Multiplayer");
Console.WriteLine(list1);

#endregion