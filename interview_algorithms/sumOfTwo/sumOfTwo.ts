function sumOfTwo(a: number[], b: number[], v: number): boolean {
    const bSet: Set<number> = new Set(b);
    for(let num of a) {
        const diff: number = v - num;
        if(bSet.has(diff)) {
            return true;
        }
    }
    return false;
}