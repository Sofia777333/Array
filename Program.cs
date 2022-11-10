using System;

namespace Array
{
    class Program
    {
     static void Main()
        {
            Array arr1 = new Array(3, 5, 7, 9);
            Array arr2 = new Array(2, 4, 6, 8);
            (arr1 * arr2).Print();
        }
    }
}
