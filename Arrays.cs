using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Arrays
    {
        public void ArrayCreation()
        {
            int[] num = new int[5];
            num[0] = 10;
            num[1] =10;

            int[] arr = { 1, 2, 3, 4, 5, 6 };

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            int[,] matrix = new int[2, 2];

            matrix[0, 0] = 1;
            matrix[1, 0] = 2;

            int[,,] mat = new int[2, 3, 4];
            Console.WriteLine(mat);

            //Array.Sort(matrix,mat);
        }
    }
}
