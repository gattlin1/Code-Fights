def areSimilar(a, b):
    if a == b:
        return True
    else:
        counter = 0
        error_loc = []
        for  i in range(len(a)):
            if a[i] != b[i]:
                counter += 1
                error_loc.append(i)
        if counter > 2:
            return False
        else:
            a[error_loc[0]], a[error_loc[1]] = a[error_loc[1]], a[error_loc[0]]
            if a == b:
                return True
            return False
