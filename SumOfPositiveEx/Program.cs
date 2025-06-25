internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(PositiveSumLinq(new int[] { 1, 2, 3, 4, 5 }));
    }

    public static int PositiveSum(int[] arr)
    {
        var result = 0;
        foreach (var num in arr) 
        {
            if(num > 0)
            {
                result += num;  
            }
        }
        return result;
    }
    public static int PositiveSumLinq(int[] arr)
    {
        // Your code here
        return arr.Sum(x => x > 0 ? x : 0);
    }
}