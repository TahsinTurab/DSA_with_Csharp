using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfDynamicArray
{
    public class vector<T>
    {
        T[] arr = new T[2];

        public int size { get; set; }
        private int currentArrSize = 2;
        public void push_back(T val)
        {
            size++;
            if(size > currentArrSize)
            {
                T[] tempArr = new T[currentArrSize];
                tempArr = arr;
                
                currentArrSize *= 2;
               
                arr = new T[currentArrSize];

                for(int i = 0; i < size - 1; i++)
                {
                    arr[i]=tempArr[i];
                }

                arr[size - 1] = val;
                
            }
            else
            {
                arr[size - 1] = val;
            }


        }
        public void pop_back()
        {
            if (size > 0)
            {
                size--;
            }
        }

        public void print()
        {
            for(int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
