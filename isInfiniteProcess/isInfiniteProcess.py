def isInfiniteProcess(a, b):
    if a > b:
        return True
    else:
        return (a - b) % 2 != 0
