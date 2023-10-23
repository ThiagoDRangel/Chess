using board;

namespace chess
{
    class Tower : Piece
    {
        public Tower(Board initialBoard, Color color) : base(initialBoard, color) { }

        public override string ToString() {
            return "T";
        }

        private bool pieceCanMove(Position position) {
            Piece pieceMove = initialBoard.piece(position);
            return pieceMove == null || pieceMove.color != color;
        }

        public override bool[,] movesPieceInBoard() { 
            bool[,] towerMoves = new bool[initialBoard.line, initialBoard.column];

            Position position = new Position(0, 0);

            // Up
            position.setValues(position.line - 1, position.column);
            while (initialBoard.isValidPosition(position) && pieceCanMove(position)) {
                towerMoves[position.line, position.column] = true;
                if (initialBoard.piece(position) != null && initialBoard.piece(position).color != color) {
                    break;
                }
                position.line = position.line - 1;
            }

            // Bottom
            position.setValues(position.line + 1, position.column);
            while (initialBoard.isValidPosition(position) && pieceCanMove(position))
            {
                towerMoves[position.line, position.column] = true;
                if (initialBoard.piece(position) != null && initialBoard.piece(position).color != color)
                {
                    break;
                }
                position.line = position.line + 1;
            }

            // Right
            position.setValues(position.line, position.column + 1);
            while (initialBoard.isValidPosition(position) && pieceCanMove(position)) {
                towerMoves[position.line, position.column] = true;
                if (initialBoard.piece(position) != null && initialBoard.piece(position).color != color)
                {
                    break;
                }
                position.column = position.column + 1;
            }


            // Left
            position.setValues(position.line, position.column - 1);
            while (initialBoard.isValidPosition(position) && pieceCanMove(position))
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
