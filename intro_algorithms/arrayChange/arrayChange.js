function arrayChange(inputArray) {
    if (inputArray.length == 1) {
        return 0;
    }
    count = 0;
    for (i = 1; i < inputArray.length; i++) {
        if (inputArray[i] <= inputArray[i - 1]) {
            nextIndex = inputArray[i - 1] - inputArray[i] + 1;
            inputArray[i] = inputArray[i - 1] + 1;
            count += nextIndex;
        }
    }
    return count;
}