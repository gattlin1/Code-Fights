function bishopAndPawn(bishop: string, pawn: string): boolean {
    const bishCol: Column = Column[bishop[0]];
    const bishRow: number = Number(bishop[1]);
    const pawnCol: Column = Column[pawn[0]];
    const pawnRow: number = Number(pawn[1]);
    const colDiff = Math.abs(bishCol - pawnCol);
    const rowDiff = Math.abs(bishRow - pawnRow);

    if(colDiff === rowDiff) {
        return true;
    }
    else {
        return false;
    }
}

enum Column {
    'a' = 1,
    'b',
    'c',
    'd',
    'e',
    'f',
    'g',
    'h'
}