using System;
using System.Collections.Generic;
using System.Text;

namespace Console_chess.Chess_pieces
{
    class Queen : piece
    {
        public Queen((int, int) cord)
        {
            name = "QUEEN";
            abv = "Q";
            position = cord;
            value = 1;
            isWhite = piececolor(cord);
        }
    }
}

