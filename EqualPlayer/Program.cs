using System;

namespace EqualPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Player> setOfPlayers = new HashSet<Player>;
            setOfPlayers.Add(new Player(PlayerClass.Tank, "Ana"));
            setOfPlayers.Add(new Player(PlayerClass.Slayer, "Paulo"));
            setOfPlayers.Add(new Player(PlayerClass.Tank, "Ana"));
        }
    }
}
