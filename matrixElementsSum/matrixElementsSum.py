def matrixElementsSum(matrix):
    roomSum = 0
    for i in range(len(matrix[0])):
        col = 0
        while col < len(matrix) and matrix[col][i] != 0:
            print(matrix[col][i], " ")
            roomSum += matrix[col][i]
            col += 1
    return roomSum;