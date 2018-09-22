function matrixElementsSum(matrix) {
    roomSum = 0;
    for (i = 0; i < matrix[0].length; i++) {
        columnIterator = 0;
        while (columnIterator < matrix.length && matrix[columnIterator][i] != 0){
            roomSum += matrix[columnIterator][i];
            columnIterator++;
        }
    }
    return roomSum;
}

