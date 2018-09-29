def makeArrayConsecutive2(statues):
    max_num = min_num = statues[0]
    for i in range(len(statues)):
        if max_num < statues[i]:
            max_num = statues[i]
        if min_num > statues[i]:
            min_num = statues[i]
            
    return max_num - min_num - (len(statues) - 1)