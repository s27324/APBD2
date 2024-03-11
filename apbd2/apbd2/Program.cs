class Program
{
    public static int Max(int[] tab)
    {
        int el = 0;
        
        foreach (int num in tab)
        {
            if (num > el)
            {
                el = num;
            }
        }

        return el;
    }

    public static double Average(int[] tab)
    {
        int sum = 0;
        int counter = tab.Length;
        foreach (int num in tab)
        {
            sum += num;
        }

        return sum / (double)counter;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] tbl = { 1, 2, 3, 4 };

        foreach (int num in tbl)
        {
            Console.WriteLine(num);
        }

        int sum = 0;
        
        foreach (int num in tbl)
        {
            sum += num;
        }
        Console.WriteLine(sum);
        int MaxNum = Max(tbl);
        Console.WriteLine(MaxNum);
        Console.WriteLine(Average(tbl));
    }
}