char firstNotRepeatingCharacter(string s) {
    Dictionary<char, int> characterCount = new Dictionary<char, int>();
    for(int i = 0; i < s.Length; i++) {
        if(characterCount.ContainsKey(s[i])) {
            characterCount[s[i]] += 1;
        }
        else {
            characterCount.Add(s[i], 1);
        }
    }
    foreach( KeyValuePair<char, int> kvp in characterCount )
    {
        if(kvp.Value == 1) {
            return kvp.Key;
        }
    }
    return '_';
}