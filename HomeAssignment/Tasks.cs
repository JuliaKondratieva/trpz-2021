using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeAssignment
{
    public class Tasks
    {
        public static List<int> Task1Function(List<object> input)
        {
            
            for (int i = input.Count; i >= 0; --i)
            {
                if(input[i] is string)
                {
                    input.RemoveAt(i);
                }
            }
            var output = input.Cast<int>().ToList();
            return output;

        }
    }
}
