function checkPalindrome(inputString) {
    for (i = 0; i < (inputString.length / 2); i++) {
        if(inputString[i] != inputString[inputString.length - 1 - i]) {
            return false;
        }   
    }
    return true;
}

