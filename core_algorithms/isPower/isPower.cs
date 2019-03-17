bool isPower(int n)
{
    if(n == 1)
    {
        return true;
    }

    double upper_bound = Math.Round(Math.Sqrt(n));

    for(double i = 2; i <= upper_bound; i++)
    {
        double value = Math.Round(Math.Pow(i, 2));

        for(double j = 3; value < n; j++)
        {
            value = Math.Round(Math.Pow(i, j));
        }
        if(value == n)
        {
            return true;
        }
    }
    return false;
}
