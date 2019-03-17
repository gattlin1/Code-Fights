int isSumOfConsecutive2(int n) {
    int num_ways = 0, upper_bound = (n / 2) + 1;
    for(int i = 1; i < upper_bound; i++)
    {
        int poss_way = 0;
        for(int j = i; poss_way < n; j++)
        {
            poss_way += j;

            if(poss_way == n)
            {
                ++num_ways;
            }
        }
    }
    return num_ways;
}
