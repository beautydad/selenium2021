
//for(statement1;statement2;statement3)
//for each sysntax
//for(data type variable names in arrayname)
using System;
namespace for_example
{
    class program
    {
        static void Main(String[] args)
        {
            string[] fruits = { "apple", "coco", "orange" };
            foreach(String ft in fruits)
                {
                Console.WriteLine(ft);
            }
        }
    }
}