﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnoWeb.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Win { get; set; }

        public virtual IEnumerable<PlayerGame> PlayerGames { get; set; }
        public virtual IEnumerable<GameCard> GameCards { get; set; }
    }
}
