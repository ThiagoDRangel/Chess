namespace board
{
    class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int quantityMove { get; protected set; }
        public Board initialBoard { get; protected set; }

        public Piece(Position position, Board initialBoard, Color color)
        {
            this.position = position;
            this.color = color;
            this.quantityMove = 0;
            this.initialBoard = initialBoard;
        }
    }
}
