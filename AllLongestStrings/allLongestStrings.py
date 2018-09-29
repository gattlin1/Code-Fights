def allLongestStrings(inputArray):
    strLength = 0
    for arrElem in inputArray:
        if len(arrElem) >= strLength:
            strLength = len(arrElem)
    
    arr = []
    for arrElem in inputArray:
        if len(arrElem) == strLength:
            arr.append(arrElem)
    return arr