def commonCharacterCount(s1, s2):
    common_characters = 0
    s1_dict = {}
    s2_dict = {}
    for letter in s1:
        if letter in s1_dict:
            s1_dict[letter] += 1
        else:
            s1_dict[letter] = 1
            
    for letter in s2:
        if letter in s2_dict:
            s2_dict[letter] += 1
        else:
            s2_dict[letter] = 1
    
    for letter in s1_dict:
        if letter in s2_dict:
            common_characters += min(s1_dict[letter], s2_dict[letter])
            
    return common_characters
