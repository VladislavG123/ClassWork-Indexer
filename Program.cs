using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexPraactick
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 4;
            int firstIndex = -9;
            ManualIndexex array = new ManualIndexex(size, firstIndex);
            for (int i = 0; i < size; i++)
            {
                array[firstIndex + i] = i;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[firstIndex + i]);
            }
            Console.Read();
        }
    }
}
