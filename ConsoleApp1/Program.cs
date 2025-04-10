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
