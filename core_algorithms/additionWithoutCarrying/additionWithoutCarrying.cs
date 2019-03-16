int additionWithoutCarrying(int param1, int param2) {
    string num1 = param1.ToString();
    string num2 = param2.ToString();
    string sum = "";

    // Make the numbers of equal lengths
    while (num1.Length != num2.Length)
    {
        if(num1.Length < num2.Length)
        {
            num1 = "0" + num1;
        }
        if(num2.Length < num1.Length)
        {
            num2 = "0" + num2;
        }
    }

    for(int i = 0; i < num1.Length; i++)
    {
        sum += ((int)Char.GetNumericValue(num1[i]) + (int)Char.GetNumericValue(num2[i])) % 10;
    }

    return Int32.Parse(sum);
}