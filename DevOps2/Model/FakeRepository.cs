using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace DevOps2.Model
{
    static class FakeRepository
    {
        static List<Studios> studios = new List<Studios>()
        {
            new Studios(1, "LAStudio", "LA", 10 ),
            new Studios(2, "MiamiStudio", "Miami", 5 ),
            new Studios(3, "CPHStudio", "Copenhagen", 3 ),
            new Studios(4, "RoskildeStudios", "Roskilde",  8)
        };

        public static readonly List<Movies> movies = new List<Movies>
        {
            new Movies(1, "Avatar", 2009, 02.42, 1),
            new Movies(2, "LOTR", 2001, 02.58, 2),
            new Movies(3, "Titanic", 1997, 03.14, 3)
        };

        public static List<Studios> GetStudio()
        {
            return studios;
        }

    }
}
