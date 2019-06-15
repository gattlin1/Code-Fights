function containsDuplicates(a: number[]): boolean {
    const set: Set<number> = new Set(a);
    return set.size !== a.length;
}