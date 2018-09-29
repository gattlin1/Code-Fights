def seatsInTheater(nCols, nRows, col, row):
    people_behind_and_same_col = nRows - row
    return (nCols - col + 1) * people_behind_and_same_col
    