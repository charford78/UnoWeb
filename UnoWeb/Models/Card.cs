﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnoWeb.Models
{
    public class Card
    {
        public int Id { get; set; }
        public enum Type {wild, one, two, three, four, five, six, seven, eight, nine, ten, skip, reverse, wildDraw4, draw2}
        public enum Color { red, blue, green, yellow, }
        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }

        public Card() { }
    }
}
