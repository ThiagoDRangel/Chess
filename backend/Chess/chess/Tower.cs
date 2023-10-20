using board;

namespace chess
{
    class Tower : Piece
    {
        public Tower(Board board, Color color) : base(board, color) { }

        public override string ToString() {
            return "T";
        }

        private bool pieceCanMovie(Position position) {
            Piece piece = initialBoard.piece(position);
            return piece == null || piece.color != color;
        }

        public override bool[,] movesPieceInBoard() {
            bool[,] towerMoves = new bool[initialBoard.line, initialBoard.column];

            Position position = new Position(0, 0);

            // Up
            position.setValues(position.line - 1, position.column);
            while (initialBoard.isValidPosition(position) && pieceCanMovie(position)) {
                towerMoves[position.line, position.column] = true;
                if (initialBoard.piece(position) != null && initialBoard.piece(position).color != color) {
                    break;
                }
                position.line = position.line - 1;
            }

            // Right
            position.setValues(position.line, position.column + 1);
            while (initialBoard.isValidPosition(position) && pieceCanMovie(position))
            {
                towerMoves[position.line, position.column] = true;
                if (initialBoard.piece(position) != null && initialBoard.piece(position).color != color)
                {
                    break;
                }
                position.column = position.column + 1;
            }

            // Bottom
            position.setValues(position.line + 1, position.column);
            while (initialBoard.isValidPosition(position) && pieceCanMovie(position))
            {
                towerMoves[position.line, position.column] = true;
                if (initialBoard.piece(position) != null && initialBoard.piece(position).color != color)
                {
                    break;
                }
                position.line = position.line + 1;
            }

            // Left
            position.setValues(position.line, position.column - 1);
            while (initialBoard.isValidPosition(position) && pieceCanMovie(position))
            {
                towerMoves[position.line, position.column] = true;
                if (initialBoard.piece(position) != null && initialBoard.piece(position).color != color)
                {
                    break;
                }
                position.column = position.column - 1;
            }
            return towerMoves;
        }
    }
}
