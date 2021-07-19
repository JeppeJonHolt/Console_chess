using System;
using System.Collections.Generic;
using System.Text;

namespace Console_chess.Chess_pieces
{
    class Bishop : piece
    {
        public Bishop((int, int) cord)
        {
            name = "BISHOP";
            abv = "B";
            position = cord;
            value = 1;
            isWhite = piececolor(cord);
        }
    }
}
