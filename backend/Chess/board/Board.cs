namespace board {
    class Board {
        public int line {  get; set; }
        public int column { get; set; }
        private Piece[,] pieces;

        public Board(int line, int column) {
            this.line = line;
            this.column = column;
            pieces = new Piece[line, column];
        }

        public Piece piece(int line, int column) {
            return pieces[line, column];
        }

        public Piece piece(Position position) {
            return pieces[position.line, position.column];
        }

        public bool existPiecePosition(Position position) {
            validetedPosition(position);
            return piece(position) != null;
        }

        public void setPieceBoard(Piece piece, Position position) {
            if (existPiecePosition(position)) {
                throw new BoardException("Error: Exist the piece in this position");
            }
            pieces[position.line, position.column] = piece;
            piece.position = position;
        }

        public Piece removePiece(Position position) {
            if (piece(position) == null) {
                return null;
            }
            Piece capturePiece = piece(position);
            capturePiece = null;
            pieces[position.line, position.column] = null;
            return capturePiece;
        }

        public bool isValidPosition(Position position) {
            if (position.line < 0 || position.column < 0 || position.line >= line || position.column >= column) {
                return false;
            }
            return true;
        }

        public void validetedPosition(Position position) {
            if (!isValidPosition(position)) {
                throw new BoardException("This position piece is invalid!");
            }
        }
    }
}
