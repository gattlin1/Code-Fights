bool evenDigitsOnly(int n) {
    string strN = n.ToString();

    for(int i = 0; i < strN.Length; i++)
    {
        int num = strN[i] - '0';
        if(num % 2 != 0)
        {
            return false;
        }
    }
    return true;
}