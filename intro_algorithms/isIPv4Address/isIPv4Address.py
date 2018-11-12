def isIPv4Address(inputString):
    ip_nums = inputString.split('.')
    if len(ip_nums) != 4:
        return False
    else:
        for values in ip_nums:
            if values == '' or not values.isdigit():
                return False
            elif int(values) > 255 and int(values) < 0:
                return False
        return True
    
