import math
def centuryFromYear(year):
    if (year % 100 >= 1):
        return math.floor(year / 100) + 1
    else:
        return math.floor(year / 100)