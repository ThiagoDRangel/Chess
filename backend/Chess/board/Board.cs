namespace board
{
    class Board
    {
        public int line {  get; set; }
        public int column { get; set; }
        private Piece[,] pieces;

        public Board(int line, int column)
        {
            this.line = line;
            this.column = column;
            pieces = new Piece[line, column];
        }

        public Piece piece(int line, int column) {
            return pieces[line, column];
        }
    }
}
