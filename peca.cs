using board;
using System;

namespace chess
{
    class Part
    {

        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int amountOfMoves { get; protected set; }
        public Board Tab { get; protected set; }

        public Part(Position position, Color color, Board tab)
        {
            Position = position;
            Color = color;
            Tab = tab;
            amountOfMoves = 0;
        }
    }
}