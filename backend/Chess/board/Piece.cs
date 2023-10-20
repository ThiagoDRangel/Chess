namespace board
{
    abstract class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int quantityMove { get; protected set; }
        public Board initialBoard { get; protected set; }

        public Piece(Board initialBoard, Color color)
        {
            this.position = null;
            this.initialBoard = initialBoard;
            this.color = color;
            this.quantityMove = 0;
        }

        public void incrementQuantityMove() { 
            quantityMove++;
        }

        public abstract bool[,] movesPieceInBoard();
    }
}
