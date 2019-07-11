function extractEachKth(inputArray: number[], k: number): number[] {
    for(let i = k - 1; i < inputArray.length; i += k) {
        inputArray.splice(i, 1);
        i--;
    }
    return inputArray
}
