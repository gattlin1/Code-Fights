function knapsackLight(value1: number, weight1: number, value2: number, weight2: number, maxW: number): number {
    if(maxW >= weight1 + weight2) {
        return value1 + value2;
    }
    if(canCarry(weight1, maxW) && canCarry(weight2, maxW)) {
        return Math.max(value1, value2);
    }
    if(canCarry(weight1, maxW) && !canCarry(weight2, maxW)) {
        return value1;
    }
    if(canCarry(weight2, maxW) && !canCarry(weight1, maxW)) {
        return value2;
    }
    else {
        return 0;
    }

}

function canCarry(weight: number, max: number) {
    return max >= weight;
}