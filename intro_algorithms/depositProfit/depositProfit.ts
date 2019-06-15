function depositProfit(deposit: number, rate: number, threshold: number): number {
    let years: number = 0;
    while(threshold > deposit) {
        deposit += deposit * rate / 100;
        ++years;
    }
    return years;
}