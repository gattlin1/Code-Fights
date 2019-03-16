int leastFactorial(int n)
{
    int smallest_factorial = 1, i = 2;
    while(smallest_factorial < n)
    {
        smallest_factorial *= i;
        ++i;
    }
    return smallest_factorial;
}