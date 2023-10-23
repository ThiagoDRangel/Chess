using System;
using board;

namespace chess
{
    class StartGame {
        public Board initialBoard { get; private set; }
        public int turn {  get; private set; }
        public Color player {  get; private set; }
        public bool gameFinished {  get; private set; }

        private HashSet<Piece> playingPieces;

        private HashSet<Piece> capturetedPieces;
        public StartGame() {
            initialBoard = new Board(8, 8);
            turn = 1;
            player = Color.white;
            gameFinished = false;
            playingPieces = new HashSet<Piece>();
            capturetedPieces = new HashSet<Piece>();
            setPieces();
        }

        public void makeMovie(Position origin, Position  destination) {
            Piece piece = initialBoard.removePiece(origin);
            piece.incrementQuantityMove();
            Piece capturedPiece = initialBoard.removePiece(destination);
            initialBoard.setPieceBoard(piece, destination);
            if (capturedPiece != null ) { 
                capturetedPieces.Add(capturedPiece);
            }
        }

        public void gamePlay(Position origin, Position destination) {
            makeMovie(origin, destination);
            turn++;
            changePlayer();
        }

        public void validOriginPosition(Position position) { 
            if (initialBoard.piece(position) == null) {
                throw new BoardException("Piece not found in this position");
            }
            if (player != initialBoard.piece(position).color) {
                throw new BoardException("Oponent piece, try again!");
            }
            if (!initialBoard.piece(position).searchPossibleMoves()) {
                throw new BoardException("Piece do not move");
            }
        }

        public void validatePositionToDestiny(Position origin, Position destination) { 
            if (!initialBoard.piece(origin).canMoveFrom(destination)) {
                throw new BoardException("Destination position is invalid!");
            }
        }

        private void changePlayer() { 
            if (player == Color.white) {
                player = Color.black;
            }
            else {
                player = Color.white;
            }
        }

        public HashSet<Piece> capturetedPiecesToColor(Color color) { 
            HashSet<Piece> result = new HashSet<Piece>();
            foreach (Piece x in capturetedPieces) { 
                if (x.color == color) { 
                    result.Add(x);
                }
            }
            return result;
        }

        public HashSet<Piece> piecesInGame(Color color) { 
            HashSet<Piece> pieces = new HashSet<Piece>();
            foreach (Piece x in playingPieces) { 
                if (x.color == color) { 
                    pieces.Add(x);
                }
            }
            pieces.ExceptWith(capturetedPiecesToColor(color));
            return pieces;
        }

        public void setNewPiece(char column, int line, Piece piece) { 
            initialBoard.setPieceBoard(piece, new PositionChess(column, line).toPosition());
            playingPieces.Add(piece);
        }

        private void setPieces() {
            setNewPiece('a', 1, new Tower(initialBoard, Color.white));
            setNewPiece('h', 1, new Tower(initialBoard, Color.white));
            setNewPiece('e', 1, new King(initialBoard, Color.white));

            setNewPiece('a', 8, new Tower(initialBoard, Color.black));
            setNewPiece('h', 8, new Tower(initialBoard, Color.black));
            setNewPiece('e', 8, new King(initialBoard, Color.black));
        }
    }
}
