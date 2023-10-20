using System;
using board;

namespace chess
{
    class StartGame {
        public Board initialBoard { get; private set; }
        public int turn {  get; private set; }
        public Color player {  get; private set; }
        public bool gameFinished {  get; private set; }

        public StartGame() {
            initialBoard = new Board(8, 8);
            turn = 1;
            player = Color.white;
            gameFinished = false;
            setPieces();
        }

        public void makeMovie(Position origin, Position  destination) {
            Piece piece = initialBoard.removePiece(origin);
            piece.incrementQuantityMove();
            Piece capturedPiece = initialBoard.removePiece(destination);
            initialBoard.setPieceBoard(piece, destination);
        }

        public void gamePlay(Position origin, Position destination) { 
            makeMovie(origin, destination);
            turn++;
            changePlayer();
        }

        private void changePlayer() { 
            if (player == Color.white) {
                player = Color.black;
            }
            else {
                player = Color.white;
            }
        }

        private void setPieces() {
            initialBoard.setPieceBoard(new Tower(initialBoard, Color.white), new PositionChess('a',1).toPosition());
            initialBoard.setPieceBoard(new Tower(initialBoard, Color.white), new PositionChess('h',1).toPosition());
            initialBoard.setPieceBoard(new King(initialBoard, Color.white), new PositionChess('e', 1).toPosition());

            initialBoard.setPieceBoard(new Tower(initialBoard, Color.black), new PositionChess('a', 8).toPosition());
            initialBoard.setPieceBoard(new Tower(initialBoard, Color.black), new PositionChess('h', 8).toPosition());
            initialBoard.setPieceBoard(new King(initialBoard, Color.black), new PositionChess('e', 8).toPosition());
        }
    }
}
