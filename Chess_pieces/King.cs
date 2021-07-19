using System;
using System.Collections.Generic;
using System.Text;

namespace Console_chess.Chess_pieces
{
    class King : piece
    {
        public King((int, int) cord)
        {
            name = "King";
            abv = "KI";
            position = cord;
            value = 1;
            isWhite = piececolor(cord);
        }
    }
}
