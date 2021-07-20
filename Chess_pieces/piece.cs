using System;
using System.Collections.Generic;
using System.Text;

namespace Console_chess.Chess_pieces
{
    abstract class piece
    {
        public string name;
        public string abv;
        public (int, int) position;
        public int value;
        public bool isWhite;
        public virtual List<(int, int)> moves() 
        {
            Console.WriteLine("Not implmented");
            return new List<(int, int)>();
        }
        public bool piececolor((int,int) cord) 
        {
            return !(cord.Item1 < 2);
        }
    }
}
