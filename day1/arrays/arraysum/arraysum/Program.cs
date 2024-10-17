namespace arraysum
{
    internal class Program
    {
        static void Main()
        {
            int sum = 0;
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
                sum = sum + arr[i];
            }
            Console.WriteLine("sum is {0}",sum);
        }
    }
}
