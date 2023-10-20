using board;

namespace chess
{
    class King : Piece {
        public King(Board board, Color color) : base(board, color) { }

        public override string ToString()
        {
            return "K";
        }

        private bool pieceCanMove(Position position) {
            Piece piece = initialBoard.piece(position);
            return piece == null || piece.color != color;
        }

        public override bool[,] movesPieceInBoard() {
            bool[,] kingMoves = new bool[initialBoard.line, initialBoard.column];

            Position position = new Position(0, 0);

            // Up
            position.setValues(position.line - 1, position.column);
            if (initialBoard.isValidPosition(position) && pieceCanMove(position)) {
                kingMoves[position.line, position.column] = true;
            }

            // North East
            position.setValues(position.line - 1, position.column + 1);
            if (initialBoard.isValidPosition(position) && pieceCanMove(position))
            {
                kingMoves[position.line, position.column] = true;
            }

            // Right
            position.setValues(position.line, position.column + 1);
            if (initialBoard.isValidPosition(position) && pieceCanMove(position))
            {
                kingMoves[position.line, position.column] = true;
            }

            // South East
            position.setValues(position.line + 1, position.column + 1);
            if (initialBoard.isValidPosition(position) && pieceCanMove(position))
            {
                kingMoves[position.line, position.column] = true;
            }

            // Bottom
            position.setValues(position.line + 1, position.column);
            if (initialBoard.isValidPosition(position) && pieceCanMove(position))
            {
                kingMoves[position.line, position.column] = true;
            }

            // South West
            position.setValues(position.line + 1, position.column - 1);
            if (initialBoard.isValidPosition(position) && pieceCanMove(position))
            {
                kingMoves[position.line, position.column] = true;
            }

            // Left
            position.setValues(position.line , position.column - 1);
            if (initialBoard.isValidPosition(position) && pieceCanMove(position))
            {
                kingMoves[position.line, position.column] = true;
            }

            // North West
            position.setValues(position.line - 1, position.column - 1);
            if (initialBoard.isValidPosition(position) && pieceCanMove(position))
            {
                kingMoves[position.line, position.column] = true;
            }
            return kingMoves;
        }
    }
}
