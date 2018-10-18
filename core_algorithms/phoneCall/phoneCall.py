def phoneCall(min1, min2_10, min11, s):
    min_talked = 0

    #for first minute
    s -= min1
    if s < 0: 
        return min_talked
    min_talked += 1
    
    #for minutes 2 - 10
    for i in range(9):
        s -= min2_10
        if s < 0: 
            return min_talked
        min_talked += 1

    #for minutes 10 & up
    while s >= 0:
        s -= min11
        if s < 0: 
            return min_talked
        min_talked += 1
    return min_talked
