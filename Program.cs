using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Hi guys I hope you are having fun. I am good here just chilling in my flat. My friends are preparing macroni for us. Hope they make it good. High expectations from them. Just Kidding!
//So lets get started guys. We'll start with something funny and then we will see where one thing will lead to another.

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal size;
            Console.WriteLine("Hello World. I am back\n");
            Console.WriteLine("Enter the size of the triangle");
            size = Convert.ToDecimal(Console.ReadLine());
            Triangle(size);
            Console.ReadKey();
        }
        public static void Triangle(decimal size)
        {
            int i, j,flag=0;
            double sized = (double)((2 * size) - 1) / 2;
            for (i = 0; i < (2*size)-1; i++)
            {
                Console.WriteLine("\n");
                for (j = 1; j <= (2 * size) - 1; j++)
                {
                    
                    if (i == size-1)
                    {
                        Console.Write("*");
                        if (j == (2 * size) - 1)
                        {
                           
                            flag = 1;
                            break;
                        }
                        
                    }
                    else
                    {
                        if (j == (ModifiedFLoor(sized) - i) || j == (ModifiedFLoor(sized) + i))
                        {
                            Console.Write('*');

                        }
                        else
                        Console.Write(" ");
                    }
                }
                if (flag == 1)
                    break;
            }
            
        }
        public static int ModifiedFLoor(double num)
        {
            int intnum=(int)num;

            if (num > intnum)
                return intnum + 1;
            else
                return intnum;
        }
    }
}
