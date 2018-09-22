function shapeArea(n) {
    if (n == 1){
        return 1;
    }
    else{
        return (n * 2) + 2 *(n - 2) + shapeArea(n - 1);
    }
}