// See https://aka.ms/new-console-template for more information

static void Main(string[] args)
{
    int[,,] ints = new int[2, 2, 2];
    int value = 1;

    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            for (int k = 0; k < ints.GetLength(2); k++)
            {
                ints[i, j, k] = value++;
            }
        }
    }
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            for (int k = 0; k < ints.GetLength(2); k++)
            {
                Console.Write(ints[i, j, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

static void Main1(string[] args)
{
    int[][] jaggedArray = new int[3][]
    {
               new int []  {1, 2, 3},
               new int []  {4, 5, 6},
               new int []  {7, 8, 9}
    };

    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            Console.Write(jaggedArray[i][j] + " ");
        }
        Console.WriteLine();
    }
    for (int i = 0; i < jaggedArray.Length; i++)
    {
        int counter = 0;
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            counter += jaggedArray[i][j];
        }
        Console.WriteLine($"{i + 1} qator: " + counter);
    }
}
