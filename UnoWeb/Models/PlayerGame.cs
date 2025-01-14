﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnoWeb.Models
{
    public class PlayerGame
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }

        public virtual Player Player { get; set; }
        public virtual Game Game { get; set; }
    }
}
