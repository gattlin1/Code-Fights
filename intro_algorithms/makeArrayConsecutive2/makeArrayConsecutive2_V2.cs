int makeArrayConsecutive2(int[] statues)
{
    int max_value, min_value;

    Array.Sort(statues);
    max_value = statues[statues.Length - 1];
    min_value = statues[0];

    return max_value - min_value - statues.Length + 1;
}