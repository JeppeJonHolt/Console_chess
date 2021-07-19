using System;
using System.Collections.Generic;
using System.Text;

namespace Console_chess.Chess_pieces
{
    class Pawn : piece
    {
        public Pawn((int,int) cord) 
        {
            name = "PAWN";
            abv = "P";
            position = cord;
            value = 1;
            isWhite = piececolor(cord);
        }
    }
}
