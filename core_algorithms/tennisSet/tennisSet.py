def tennisSet(score1, score2):
    maxVal, minVal = max(score1, score2), min(score1, score2)
    if maxVal == 6 and minVal < 5:
        return True
    elif maxVal == 7 and minVal in [5,6]:
        return True
    else:
        return False
