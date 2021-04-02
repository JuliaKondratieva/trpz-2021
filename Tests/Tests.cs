using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using HomeAssignment;


namespace Tests
{
    public class Tests
    {

        [TestCase(1,"a",1)]
        public void Test1(int i1, string s1, int i2)
        {
            var input = new List<object>();
            input.Add(i1);
            input.Add(s1);
            var output = new List<int>();
            input.Add(i2);
            // var input = new List<object>() { 1, 2, "a", "b" };

            // var output = new List<int>() { 1, 2 };        


            //CollectionAssert.AreEqual(expected, actual);
            var result = Tasks.Task1Function(input);
            CollectionAssert.AreEqual(output, result, "Returned result is incorrect");
        }

    }
}
