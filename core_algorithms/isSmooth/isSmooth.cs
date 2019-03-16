bool isSmooth(int[] arr) {
    int middle = 0;
    if(arr.Length % 2 == 0)
    {
        int middle_value1 = arr[(arr.Length - 1) / 2];
        int middle_value2 = arr[(arr.Length - 1) / 2 + 1];
        middle = middle_value1 + middle_value2;
    }
    else
    {
        middle = arr[arr.Length / 2];
    }
    if(middle == arr[0] && middle == arr[arr.Length - 1])
    {
        return true;
    }
    else
    {
        return false;
    }
}
