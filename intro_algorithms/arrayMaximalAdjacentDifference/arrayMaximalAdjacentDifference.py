def arrayMaximalAdjacentDifference(inputArray):
    max_diff = 0
    for i in range(1,len(inputArray)):
        if abs(inputArray[i] - inputArray[i - 1]) > max_diff:
            max_diff = abs(inputArray[i] - inputArray[i - 1])
    return max_diff