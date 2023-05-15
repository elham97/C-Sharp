namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2] {1,2};

            Console.WriteLine(arr);

            int[,] arr1 = new int[2, 2];
            arr1[0, 0] = 1;
            arr1[0, 1] = 2;
            arr1[1, 0] = 3;
            arr1[1, 1] = 4;
          

            Console.WriteLine(arr1);

            int[][] arr2 = new int[3][];
            arr2[0] = new int[] { 1, 2, 3 };
            arr2[0] = new int[] { 5, 3 };
            arr2[0] = new int[] { 7, 6, 9, 0 };

            int element = arr2[1][2];
            Console.WriteLine(element);
            
            int[] elements = new int[] { 4, 5, 6, 7, 8 };

            int[] slice = elements[2..4];
            Console.WriteLine(slice[0]);
            int[] slice22 = elements[2..^3];
            int[] slice1 = elements[..4];
            int[] slice2 = elements[2..];
            int[] slice3 = elements[..];
            Console.WriteLine(slice2[0]);
            
            

        }
    }
}