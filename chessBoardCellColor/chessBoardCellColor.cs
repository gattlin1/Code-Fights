bool chessBoardCellColor(string cell1, string cell2) {
    // Gets the numberic value of each row and converts the letter into
    // a column index
    int cell1_row = int.Parse(cell1[1].ToString());
    int cell2_row = int.Parse(cell2[1].ToString());
    int cell1_col = (int)cell1[0] % 32;
    int cell2_col = (int)cell2[0] % 32;

    if(is_even(cell1_row) == is_even(cell2_row))
    {
        return is_even(cell1_col) == is_even(cell2_col);
    }
    else
    {
        return is_even(cell1_col) != is_even(cell2_col);
    }
}

bool is_even(int value)
{
    return value % 2 == 0;
}