﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var players = new[] { new Player("Vladimir", 10, random), new Player("Przemek", 10, random), new Player("Mieczyslaw", 10, random) };
            for (var round = 1; round <= 10; round++)
            {
                var playerIndex1 = random.Next(players.Length);
                var playerIndex2 = (playerIndex1 + 1 + random.Next(2)) % players.Length;
                var player1 = players[playerIndex1];
                var player2 = players[playerIndex2];
                player1.Play(player2);
            }
            foreach (var player in players)
            {
                player.ShowNameAndPoints(random);
            }
        }
    }
}
