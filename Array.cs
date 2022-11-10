using System;
using System.Collections.Generic;


namespace Array
{
     class Array
    {
        public int Length => _array.Length;
        private int[] _array;
        public Array(int size) => _array = new int[size];
        public Array(params int[] array) => _array = array;
        public int this [int index]
        {
            get => _array [index];
            set => _array [index] = value;
        }
        public static Array operator +(Array lhs, Array rhs) 
            => CalculateElements(lhs, rhs, (x, y) => x + y);
        public static Array operator -(Array lhs, Array rhs)
            => CalculateElements(lhs, rhs, (x, y) => x - y);

        public static Array operator *(Array lhs, Array rhs)
            => CalculateElements(lhs, rhs, (x, y) => x * y);


        public static Array operator /(Array lhs, Array rhs)
            => CalculateElements(lhs, rhs, (x, y) => x /y);

        public static Array operator %(Array lhs, Array rhs)
            => CalculateElements(lhs, rhs, (x, y) => x % y);
        
        public static Array CalculateElements(Array lhs, Array rhs, Func<int,int, int> operation)
        
        { Array min = lhs.Length > rhs.Length ? rhs : lhs;
            Array max = ReferenceEquals(min, lhs) ? lhs : rhs;

            Array array = new Array(max.Length);
            for (int i = 0; i < max.Length; i++)
            {
                if (i >= min.Length)
                {
                    array[i] = max[i];
                    continue;
                }

                array[i] = operation.Invoke(lhs[i], rhs[i]);
            }
            return array;
        }
           public void Print()
           {
            foreach (int element in _array)
                Console.WriteLine($"{element}");

           }

    }
     

        
}
