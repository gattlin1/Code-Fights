bool sudoku2(char[][] grid) {
    HashSet<int> numCount = new HashSet<int>();
    for(int i = 0; i < grid.Length; i++) {
        Console.WriteLine("\nRow checking:");

        // For checking if any row has more one of each number
        for(int j = 0; j < grid[i].Length; j++) {
            Console.Write(char.IsDigit(grid[i][j]));
            if(char.IsDigit(grid[i][j])) {
                if(numCount.Contains(grid[i][j])) {
                    return false;
                }
                else {
                    numCount.Add(grid[i][j]);
                }
            }
        }
        Console.WriteLine("\nColumn checking:");
        numCount.Clear();

        // For checking if any column has more than one of each number
        for(int j = 0; j < grid[i].Length; j++) {
            Console.Write(char.IsDigit(grid[j][i]));
            if(char.IsDigit(grid[j][i])){
                if(numCount.Contains(grid[j][i])) {
                return false;
                }
                else {
                    numCount.Add(grid[j][i]);
                }
            }
        }
        numCount.Clear();
    }

    for(int i = 0; i < grid.Length; i += 3)
    {
        for(int j = 0; j < grid[i].Length; j += 3)
        {
            for(int z = 0; z < 3; z += 1)
            {
                for(int q = 0; q < 3; q += 1)
                {
                    char sudokuSpot = grid[i + z][j + q];
                    if(char.IsDigit(sudokuSpot))
                    {
                        if(numCount.Contains(sudokuSpot))
                        {
                            return false;
                        }
                        else
                        {
                            numCount.Add(sudokuSpot);
                        }
                    }
                }
            }
            numCount.Clear();
        }
    }
    return true;
}
