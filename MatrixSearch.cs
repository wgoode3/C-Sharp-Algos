using System;

namespace C_Sharp_Algos
{
    public static class MatrixSearch
    {
        
        // find a smaller image inside of a larger canvas
        public static bool Search(int[,] canvas, int[,] image)
        {
            int height = canvas.GetLength(0) - (image.GetLength(0) - 1);
            int width = canvas.GetLength(1) - (image.GetLength(1) - 1);
            for(int i=0; i<height; i++)
            {
                for(int j=0; j<width; j++)
                {
                    // see if the first pixel in image is found in canvas
                    if(image[0,0] == canvas[i,j])
                    {
                        bool found = true;
                        for(int k=0; k<image.GetLength(0); k++)
                        {
                            for(int l=0; l<image.GetLength(1); l++)
                            {
                                if(canvas[i+k,j+l] != image[k,l])
                                {
                                    found = false;
                                }
                            }
                        }
                        if(found)
                            return true;
                    }
                }
            }
            return false;
        }

    }
}