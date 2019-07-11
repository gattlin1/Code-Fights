function differentSymbolsNaive(s: string): number {
    const diff = new Set(s.split(""));
    return diff.size;
}