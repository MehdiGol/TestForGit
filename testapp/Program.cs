using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (checkvalue(1))
            {
                Console.WriteLine("Hello world!!");
            }
        }

        static bool checkvalue(int a)
        {
            if (a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
