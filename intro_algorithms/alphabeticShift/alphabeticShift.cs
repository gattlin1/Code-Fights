string alphabeticShift(string inputString) {
    string alphabet = "abcdefghijklmnopqrstuvwxyza";
    string shifted = "";

    for (int i = 0; i < inputString.Length; i++) {
        shifted += alphabet[alphabet.IndexOf(inputString[i]) + 1];
    }

    return shifted;
}