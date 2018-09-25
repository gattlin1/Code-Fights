function isLucky(n) {
    n = n.toString();
    firstHalf = n.slice(0,n.length/2);
    secondHalf = n.slice(n.length/2, n.length);
    firstSum = secondSum = 0;
    
    for (i = 0; i < n.length / 2; i++) {
        firstSum += parseInt(firstHalf[i], 10);
        secondSum += parseInt(secondHalf[i], 10);
    }
    if (firstSum == secondSum) {
        return true;
    }
    else {
        return false;
    }
}