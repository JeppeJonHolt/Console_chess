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
        public void moves() 
        {
            Console.WriteLine("Not implmented");
        }
        public bool piececolor((int,int) cord) 
        {
            return !(cord.Item1 < 2);
        }
    }
}
