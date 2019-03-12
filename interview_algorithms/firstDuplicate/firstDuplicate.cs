int firstDuplicate(int[] a) {
    HashSet<int> numCounter = new HashSet<int>();
    for(int i = 0; i < a.Length; i++) {
        if(numCounter.Contains(a[i])) {
            return a[i];
        }    
        else {
            numCounter.Add(a[i]);
        }
    }
    return -1;
}
