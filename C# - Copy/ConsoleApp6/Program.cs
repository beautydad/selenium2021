using System;
namespace break_continue_example
{
    class program
    {
        static void Main(String[]args)
        {
            int j = 0;
            while(j<15)
            {
               

                if(j==7)
                    {
                    j++;

                    continue;
                    }
                Console.WriteLine(j);
                j++;

            }
        }
        }
    }
