//Write a program that takes an integer array of size 6, 
//  reverses the array in place, 
//  and prints the reversed array.[1,2,4,3,6]
//                                [6,3,4,2,1]

namespace reversearr
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter six integers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"enter {i+1} element: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;


                left++;
                right--;

            }
            Console.WriteLine("Reversed array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
