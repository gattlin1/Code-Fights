def avoidObstacles(inputArray):
    found_min = False
    min_num = i = 0
    while not found_min:
        min_num += 1
        i = 0
        while i < max(inputArray):
            i += min_num
            if i in inputArray:
                break
            elif i > max(inputArray):
                return min_num