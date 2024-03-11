class Program
{
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
    }
}