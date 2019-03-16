int appleBoxes(int k) {
    int red_apples = 0, yellow_apples = 0;

    for (int i = 1; i <= k; i++)
    {
        if(i % 2 == 0)
        {
            red_apples += i * i;
        }
        else
        {
            yellow_apples += i * i;
        }
    }
    return red_apples - yellow_apples;
}
