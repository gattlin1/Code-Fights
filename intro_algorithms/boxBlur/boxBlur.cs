int[][] boxBlur(int[][] image) {
    List<List<int>> box_blur_values = new List<List<int>>();
    int square_len = 3;

    for(int i = 0; i < image.Length - 2; i++)
    {
        List<int> row_blur_values = new List<int>();
        box_blur_values.Add(row_blur_values);

        for(int j = 0; j < image[i].Length - 2; j++)
        {
            int individual_value = 0;

            for(int z = 0; z < square_len; z++)
            {
                for(int q = 0; q < square_len; q++)
                {
                    individual_value += image[i + z][j + q];
                }
            }
            row_blur_values.Add(individual_value / 9);
        }
    }

    int[][] blur_arr = new int[box_blur_values.Count][];

    // Converting the List of Lists to an multidimensional array.
    for(int i = 0; i < box_blur_values.Count; i++)
    {
        blur_arr[i] = box_blur_values[i].ToArray();
    }

    return blur_arr;
}
