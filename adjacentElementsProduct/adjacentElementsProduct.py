def adjacentElementsProduct(inputArray):
    largest_sum = inputArray[0] * inputArray[1]
    for i in range(1, len(inputArray) - 1):
        if inputArray[i] * inputArray[i + 1] >= largest_sum:
            largest_sum = inputArray[i] * inputArray[i + 1]
    return largest_sum