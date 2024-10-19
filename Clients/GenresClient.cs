using GameStore.Models;

namespace GameStore.Clients;

public class GenresClient
{
    private readonly Genre[] genres =
    {
        new (){
            Id = 1,
            Name = "Fighting"
        },
        new (){
            Id = 2,
            Name = "Adventure"
        },
        new (){
            Id = 3,
            Name = "RPG"
        },
        new (){
            Id = 4,
            Name = "Puzzle"
        },
        new (){
            Id = 5,
            Name = "Strategy"
        },
        new (){
            Id = 6,
            Name = "Shooter"
        },
        new (){
            Id = 7,
            Name = "Simulation"
        },
        new (){
            Id = 8,
            Name = "Sports"
        },
        new (){
            Id = 9,
            Name = "Racing"
        },
        new (){
            Id = 10,
            Name = "Horror"
        },
        new (){
            Id = 11,
            Name = "Platformer"
        }

    };

    public Genre[] GetGenres() => genres;

}
