using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new1
{
    public class MyArray<T>
    {
        private T[] array;

        public MyArray(int size)
        {
            array = new T[size];
        }

        public void AddElement(T element, int index)
        {
            array[index] = element;
        }

        public T GetElement(int index)
        {
            
            return array[index];
        }

        public void RemoveElement(int index)
        {
            array[index] = default(T);
        }
        public int GetLength()
        {
            return array.Length;
        }
    }
}
   

