using System;
using System.Collections.Generic;

namespace ReverseArray
{
    public class ReverseService
    {
        //not creating a new array for better memory performance. 
        //I heard that you can even not doing a temporary value by using XOR. 
        //However, this seems to be a very micro optimilisation and as Donald Knuth said:
        //"premature optimization is the root of all evil."
        public void Reverse<T>(IList<T> array)
        {
            if (array is null) 
                return;

            for (int i = 0, j= array.Count - 1; i <array.Count/2; ++i, --j)
            {
                var element = array[i];
                array[i] = array[j];
                array[j] = element;
            }
        }
    }
}
