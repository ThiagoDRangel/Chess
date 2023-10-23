namespace board
{
    abstract class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int quantityMove { get; protected set; }
        public Board initialBoard { get; protected set; }

        public Piece(Board initialBoard, Color color) {
            this.position = null;
            this.initialBoard = initialBoard;
            this.color = color;
            this.quantityMove = 0;
        }

        public void incrementQuantityMove() { 
            quantityMove++;
        }

        public bool searchPossibleMoves() {
            bool[,] saveMoves = movesPieceInBoard();
            for (int i = 0; i < initialBoard.line; i++) { 
                for (int j = 0; j < initialBoard.column; j++) { 
                    if (saveMoves[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool canMoveFrom(Position position) { 
            return movesPieceInBoard()[position.line, position.column];
        }

        public abstract bool[,] movesPieceInBoard();
    }
}
