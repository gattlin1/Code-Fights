function adjacentElementsProduct(inputArray) {
    largestSum = inputArray[0] * inputArray[1];
    for (i = 1; i < inputArray.length - 1; i++){
        if (inputArray[i] * inputArray[i + 1] >= largestSum){
            largestSum = inputArray[i] * inputArray[i + 1];
        }
    }
    return largestSum;
}