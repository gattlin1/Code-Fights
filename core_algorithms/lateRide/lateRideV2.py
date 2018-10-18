import math
def lateRide(n):
    hour = n / 60
    minutes = n % 60
    return math.floor(hour / 10) + math.floor(hour % 10) + math.floor(minutes / 10) + math.floor(minutes % 10)