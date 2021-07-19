using System;
using System.Collections.Generic;
using System.Text;

namespace Console_chess.Chess_pieces
{
    class Rook:piece
    {
        public Rook((int, int) cord)  
        {
            name = "ROOK";
            abv = "R";
            position = cord;
            value = 1;
            isWhite = piececolor(cord);
        }
    }
}
