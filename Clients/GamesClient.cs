using GameStore.Models;

namespace GameStore.Clients;

public class GamesClient
{

    private readonly List<GameSummary> games = [
        new(){
            Id = 1,
            Name = "DBZ Sparking Zero",
            Genre = "Fighting",
            Price = 29.99M,
            ReleaseDate = new DateOnly(2024, 10 , 10)
        },
            new(){
            Id = 2,
            Name = "Galactic Explorers",
            Genre = "Adventure",
            Price = 49.99M,
            ReleaseDate = new DateOnly(2025, 3, 15)
        },

            new(){
            Id = 3,
            Name = "Puzzle Masters",
            Genre = "Puzzle",
            Price = 19.99M,
            ReleaseDate = new DateOnly(2023, 11, 22)
        },

            new(){
            Id = 4,
            Name = "Racing Legends",
            Genre = "Racing",
            Price = 39.99M,
            ReleaseDate = new DateOnly(2024, 6, 5)
        },

            new(){
            Id = 5,
            Name = "Zombie Survival",
            Genre = "Horror",
            Price = 34.99M,
            ReleaseDate = new DateOnly(2024, 1, 28)
        },

            new(){
            Id = 6,
            Name = "Fantasy Quest",
            Genre = "RPG",
            Price = 59.99M,
            ReleaseDate = new DateOnly(2025, 7, 30)
        }

            ];

    public GameSummary[] GetGames() => games.ToArray();

    private readonly Genre[] genres = new GenresClient().GetGenres();

    public void AddGame(GameDetails game)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId);
        var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));

        var gameSummary = new GameSummary
        {
            Id = games.Count + 1,
            Name = game.Name,
            Genre = genre.Name,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };

        games.Add(gameSummary);
    }
}
