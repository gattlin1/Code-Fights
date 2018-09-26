function evenFibSum() {
    fib = [1, 2];
    i = 1;
    sum = 0;
    while (fib[i] <= 4000000) {
        nextValue = fib[i - 1] + fib[i];
        fib.push(nextValue);
        i++;
    }
    for (i = 0; i < fib.length; i++) {
        if (fib[i] % 2 == 0) {
            sum += fib[i];
        }
    }
    console.log(sum);
}

evenFibSum();