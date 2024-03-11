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
    }
}