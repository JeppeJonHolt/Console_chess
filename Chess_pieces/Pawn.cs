using System;
using System.Collections.Generic;
using System.Text;

namespace Console_chess.Chess_pieces
{
    class Pawn : piece
    {
        bool hasMoved = false;
        public Pawn((int,int) cord) 
        {
            name = "PAWN";
            abv = "P";
            position = cord;
            value = 1;
            isWhite = piececolor(cord);
        }

        public override List<(int,int)> moves()
        {
            List<(int, int)> moveList = new List<(int, int)>();
            int moveDist = 1;
            if (!hasMoved)
            {
                hasMoved = true;
                moveList.Add((position.Item1 - (moveDist + 1), position.Item2));
            }
            moveList.Add((position.Item1 - moveDist, position.Item2));
            foreach (var move in moveList)
            {
                Console.WriteLine(move);
            }
            return moveList;
        }

        public override bool move((int,int) distination) 
        {
            if (moves().Contains(distination))
            {
                return true;
            }
            return false;
        }
    }
}
