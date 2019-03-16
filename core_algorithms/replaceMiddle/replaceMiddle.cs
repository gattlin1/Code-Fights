int[] replaceMiddle(int[] arr) {
    if(arr.Length % 2 == 0)
    {
        int middle = 0;
        int middle_value1 = (arr.Length - 1) / 2;
        int middle_value2 = (arr.Length - 1) / 2 + 1;
        middle = (arr[middle_value1] + arr[middle_value2]);
        arr[middle_value2] = middle;

        List<int> combined_middle = new List<int>(arr);
        combined_middle.RemoveAt(middle_value1);

        return combined_middle.ToArray();
    }
    else
    {
        return arr;
    }
}
