function addBorder(picture) {
    //adds star to front and back of each element in array
    for (i = 0; i < picture.length; i++) {
        picture[i] = "*" + picture[i] + "*";
    }
    
    picture.unshift("*".repeat(picture[0].length)); // adds star to front of array
    picture.push("*".repeat(picture[0].length)); // adds star to back of array
    
    return picture;
}