function firstDigit(inputString: string): string {
    let reg = /[0-9]/;
    for( let i=0; i<inputString.length; i++ ) {
        if( reg.test(inputString[i]) )
            return inputString[i];
    }
}