int makeArrayConsecutive2(int[] statues)
{
    int statues_needed = 0, difference = 0;
    Array.Sort(statues);

    for(int i = 0; i < statues.Length - 1; i++)
    {
        difference = statues[i + 1] - statues[i];
        if(difference > 1)
        {
            statues_needed += difference - 1;
        }
    }
    return statues_needed;
}
