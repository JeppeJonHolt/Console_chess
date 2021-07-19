using Console_chess.Chess_pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_chess.Chess_board
{
    class Field
    {
        public bool isWhite;
        public (int, int) cord;
        public piece _piece;

        public Field(bool isWhite, (int,int) cord) 
        {
            this.isWhite = isWhite;
            this.cord = cord;
        }

        public string GetColor() 
        {
            if (isWhite)
            {
                return "W";
            }
            else
            {
                return "B";
            }
        }
    }
}
