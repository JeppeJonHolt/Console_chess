using System;
using System.Collections.Generic;
using System.Text;

namespace Console_chess.Chess_pieces
{
    class Knight : piece
    {
        public Knight((int, int) cord)
        {
            name = "KNIGHT";
            abv = "K";
            position = cord;
            value = 1;
            isWhite = piececolor(cord);
        }
    }
}
