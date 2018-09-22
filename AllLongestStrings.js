function allLongestStrings(inputArray) {
    maxLen = 0;
    for (i = 0; i < inputArray.length; i++) {
        if (inputArray[i].length > maxLen) {
            maxLen = inputArray[i].length;
        }
    }
    
    longestStringsArray = [];
    for (i = 0; i < inputArray.length; i++) {
        if (inputArray[i].length == maxLen) {
            longestStringsArray.push(inputArray[i]);
        }
    }
    return longestStringsArray;
}

