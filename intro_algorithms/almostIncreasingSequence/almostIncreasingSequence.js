function almostIncreasingSequence(sequence) {
    faultsInSequence = 0;
    for (i = 1; i < sequence.length; i++) {
        if (sequence[i - 1] >= sequence[i]) {
            faultsInSequence++;
            if (sequence[i] <= sequence[i - 2] && sequence[i + 1] <= sequence[i - 1]) {
                return false;
            }
        }
    }
    return faultsInSequence <= 1;
}