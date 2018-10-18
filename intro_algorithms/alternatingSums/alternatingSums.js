function alternatingSums(a) {
    evenIndexSum = oddIndexSum = 0;
    for (i = 0; i < a.length; i++) {
        if (i % 2 == 0) {
            evenIndexSum += a[i];
        }
        else {
            oddIndexSum += a[i];
        }
    }
    return [evenIndexSum, oddIndexSum];
}