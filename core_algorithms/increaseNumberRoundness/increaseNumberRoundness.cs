bool increaseNumberRoundness(int n) {
    string number = n.ToString();
    int i = 0;

    while (i < number.Length)
    {
        if(number[i] == '0')
        {
            while(i < number.Length)
            {
                if(number[i] != '0')
                {
                    return true;
                }
                ++i;
            }
        }
        ++i;
    }
    return false;
}
