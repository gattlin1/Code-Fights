function makeArrayConsecutive2(statues) {
    maxNum = minNum = statues[0];
    for (i = 1; i < statues.length; i++){
        if (statues[i] > maxNum){
            maxNum = statues[i]
        } 
        if(statues[i] < minNum){
            minNum = statues[i]
        }
    }
    //this works because I got the min and max num of the array
    //so all of the other nums in the array are inbetween them
    //so if subtract the max from the min and subtract the numbers
    //already inbetween the max and the mind num. Also we dont have
    //to worry about duplicates because of the instructions.
    return (maxNum - minNum - (statues.length - 1))
}

