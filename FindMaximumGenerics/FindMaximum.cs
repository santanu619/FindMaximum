using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumGenerics
{
    class FindMaximum<T> where T : IComparable<T> 
    {
        private T value1;
        private T value2;
        private T value3;

        public FindMaximum(T value1, T value2, T value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public string FindMaxGenerics()
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
                return value1.ToString();
            else if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0)
                return value2.ToString();
            else if (value3.CompareTo(value1) > 0 && value3.CompareTo(value2) > 0)
                return value3.ToString();
            else throw new Exception("Values are same");
        }
            
                
    }
}
