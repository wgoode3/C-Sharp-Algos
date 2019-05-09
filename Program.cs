using System;

namespace C_Sharp_Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Algorithms");

            int[,] canvas = new int[,] {{1,2,0,2}, 
                                        {0,3,5,4}, 
                                        {5,1,1,6}, 
                                        {0,7,2,8}};
            int[,] img1 = new int[,] {{1,6}, 
                                      {2,8}};
            int[,] img2 = new int[,] {{1,6}, 
                                      {0,3}};

            // Console.WriteLine($"The number of elements is: {canvas.Length}");
            // Console.WriteLine($"The number of dimensions is: {canvas.Rank}");
            // Console.WriteLine($"The height is: {canvas.GetLength(0)}");
            // Console.WriteLine($"The width is: {canvas.GetLength(1)}");

            Console.WriteLine(MatrixSearch.Search(canvas, img1));
            Console.WriteLine(MatrixSearch.Search(canvas, img2));
            
        }
    }
}
