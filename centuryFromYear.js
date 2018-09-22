function centuryFromYear(year) {
    if (year % 100 >= 1){
        return Math.floor(year / 100) + 1;
    }
    else{
        return Math.floor(year / 100);
    }
}