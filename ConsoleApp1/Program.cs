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

static void Main3(string[] args)
{
    int[] ints = { 1, 2, 3, 4, 5 };

    string counter = "";
    for (int i = 0; i < ints.Length; i++)
    {
        counter = Convert.ToString(ints[i] + " ") + counter;
    }
    Console.WriteLine(counter);
}


static void Main4(string[] args)
{
    int[,] ints = new int[4, 3];

    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Random rnd = new Random();
            ints[i, j] = rnd.Next(1, 10);
        }
    }

    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Console.Write(ints[i, j] + " ");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < ints.GetLength(0); i++)
    {
        int max = ints[i, 0];
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            if (ints[i, j] > max) max = ints[i, j];
        }
        Console.WriteLine($" {i + 1} qator: " + max);
    }

}

static void Main5(string[] args)
{
    int cros = Convert.ToInt32(Console.ReadLine());

    int[][] jaggedArray = new int[cros][];

    Console.WriteLine();

    for (int i = 0; i < cros; i++)
    {
        int jagged = Convert.ToInt32(Console.ReadLine());

        jaggedArray[i] = new int[jagged];

        for (int j = 0; j < jagged; j++)
        {
            jaggedArray[i][j] = Convert.ToInt32(Console.Read() + " ");
        }
    }
    Console.WriteLine();

    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            Console.Write(jaggedArray[i][j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");