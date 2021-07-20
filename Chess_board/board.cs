using Console_chess.Chess_pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_chess.Chess_board
{
    class board
    {
        Field[,] fields = new Field[8,8];

        public board() 
        {
            Console.WriteLine("Generating board");
            generateBoard();
            Console.WriteLine("Finished generating board");
            printboard();
            Console.WriteLine("To select piece input first row then colum");
            string row = Console.ReadLine();
            string col = Console.ReadLine();
            selectPiece((Int32.Parse(row), Int32.Parse(col)));

        }

        public void selectPiece((int,int) cord) 
        {
            foreach (var move in fields[cord.Item1, cord.Item2]._piece.moves())
            {
                Console.WriteLine(move);
            }
        }

        public void generateBoard() 
        {
            for(int i = 0; i < 8; i++) 
            {
                for (int j = 0; j < 8; j++) 
                {
                    fields[i,j] = new Field(colorselector((i, j)), (i, j));
                }
            }
            populateBoard();
        }

        public bool colorselector((int,int) cord) 
        {
            if (cord.Item1 % 2 == 0) 
            {
                if (cord.Item2 % 2 == 0)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            else 
            {
                if (cord.Item2 % 2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public void printboard() 
        {
            for (int i = 0; i < 8; i++)
            {
                string row = "";
                for (int j = 0; j < 8; j++)
                {
                    string isrook = "";
                    if (fields[i, j]._piece != null)
                    {
                        isrook = "-" + fields[i, j]._piece.abv;
                    }
                    row += fields[i, j].GetColor()+ isrook+"|";
                }
                Console.WriteLine(row);
            }
        }

        public void populateBoard() 
        {
            populatePawns();
            populateRook();
            populateKnight();
            populateBishop();
            populateQueens();
            populateKings();
        }

        public void populatePawns() 
        {
            for (int i = 0; i < 8; i++)
            {
                fields[1, i]._piece = new Pawn((1,i));
                fields[6, i]._piece = new Pawn((6, i));
            }
        }

        public void populateRook()
        {
            fields[0, 0]._piece = new Rook((0,0));
            fields[0, 7]._piece = new Rook((0,7));
            fields[7, 0]._piece = new Rook((7,0));
            fields[7, 7]._piece = new Rook((7,7));
        }

        public void populateKnight()
        {
            fields[0, 1]._piece = new Knight((0, 1));
            fields[0, 6]._piece = new Knight((0, 6));
            fields[7, 1]._piece = new Knight((7, 1));
            fields[7, 6]._piece = new Knight((7, 6));
        }

        public void populateBishop()
        {
            fields[0, 2]._piece = new Bishop((0, 2));
            fields[0, 5]._piece = new Bishop((0, 5));
            fields[7, 2]._piece = new Bishop((7, 2));
            fields[7, 5]._piece = new Bishop((7, 5));
        }

        public void populateQueens()
        {
            fields[0, 3]._piece = new Queen((0, 2));
            fields[7, 3]._piece = new Queen((7, 5));
        }

        public void populateKings()
        {
            fields[0, 4]._piece = new King((0, 2));
            fields[7, 4]._piece = new King((7, 5));
        }
    }
}
