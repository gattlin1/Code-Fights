function sortByHeight(a) {
    nonTreeValues = new Array();
    for (i = 0; i < a.length; i++) {
        if (a[i] != -1) {
            nonTreeValues.push(a[i]);//pulls out the non tree values into a new array.
        }
    }
    
    insertionSort(nonTreeValues);//array is now sorted.
    
    for (i = 0; i < a.length; i++) {
        if (a[i] != -1) {
            a[i] = nonTreeValues.pop();//pops off the last value which is the smallest non tree value
            
        }
    }
    
    return a;
}

//Sorts the array in descending order. That way we can pop the values
//off the end into the array with the tree values.
function insertionSort(a) {
    for (j = 1; j < a.length; j++) {
        key = a[j];
        
        i = j - 1;
        
        while (i >= 0 && a[i] < key) {
            a[i + 1] = a[i];
            i--;
        }
        a[i + 1] = key;
    }
    return a;
}