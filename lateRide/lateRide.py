import math
def lateRide(n):
    time = str(round(n / 60, 2))
    hours, minutes = time.split('.')
    minutes = str(round(float('0.' + minutes) * 60))
    sum = 0 
    for hour in hours:
        sum += int(hour)
    for min in minutes:
        sum += int(min)
    return sum