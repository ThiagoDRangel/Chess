namespace board
{
    class Board
    {
        public int line {  get; set; }
        public int column { get; set; }
        private Piece[,] pieces;
        private int v1;
        private int v2;

        public Board(int line, int column, Piece[,] pieces)
        {
            this.line = line;
            this.column = column;
            pieces = new Piece[line, column];
        }

        public Board(int line, int column)
        {
            this.line = line;
            this.column = column;
        }
    }
}
