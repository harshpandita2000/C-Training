namespace minmax
{
    internal class Program
    {
        static void Main()
        {
            
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            int min = arr[0];
            for (int i = 1;i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];

            }
            Console.WriteLine("max: {0}\nmin: {1}",max,min);
            
        }
    }
}
