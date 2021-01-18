using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericClass
{
    class GenericList<T> where T : IComparable<T>
    {
        private int capacity;
        private int lastIndex;
        private T[] array;
        public GenericList(int n)
        {
            capacity = n;
            array = new T[n];
            lastIndex = -1;
        }

        public void Add(T element)
        {
            if(lastIndex == capacity - 1)
            {
                Array.Resize(ref array, array.Length * 2);
                capacity *= 2;
            }
            array[++lastIndex] = element;
        }

        public T At(int index)
        {
            if(index < 0 || index >= capacity)
            {
                Console.WriteLine("Invalid index.");
                return array[0];
            }
            else if(index > lastIndex)
            {
                Console.WriteLine("There is not value at index : {0}", index);
                return array[0];
            }
            else
            {
                return array[index];
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= capacity)
            {
                Console.WriteLine("Invalid index.");
            }
            else if (index > lastIndex)
            {
                Console.WriteLine("There is not value at index : {0}", index);
            }
            else
            {
                for (int i = index; i < lastIndex; i++)
                {
                    array[i] = array[i + 1];
                }
            }
            lastIndex--;
        }

        public void AddAt(int index, T element)
        {
            if (index < 0 || index >= capacity)
            {
                Console.WriteLine("Invalid index.");
            }
            else if (index > lastIndex)
            {
                Console.WriteLine("There is not value at index : {0}", index);
            }
            else
            {
                if(lastIndex + 1 < capacity)
                {
                    lastIndex++;
                }

                else
                {
                    Array.Resize(ref array, array.Length * 2);
                    capacity *= 2;
                    lastIndex++;
                }
                
                for (int i = lastIndex; i > index; i--)
                {
                    array[lastIndex] = array[i - 1];
                }

                array[index] = element;
            }
        }

        public void ClearArray()
        {
            lastIndex = -1;
        }

        public int Find(T element)
        {
            for (int i = 0; i <= lastIndex; i++)
            {
                if(array[i].ToString() == element.ToString())
                {
                    return i;
                }
            }

            return -1;
        }

        public override string ToString()
        {
            string text = "";

            for (int i = 0; i <= lastIndex; i++)
            {
                text += i + " => " + array[i].ToString() + "\n";
            } 

            return text;
        }

        public T Min()
        {
            T minValue = array[0];

            for (int i = 0; i <= lastIndex; i++)
            {
                if(int.Parse(array[i].ToString()) < int.Parse(minValue.ToString()))
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }

        public T Max()
        {
            T maxValue = array[0];

            for (int i = 0; i <= lastIndex; i++)
            {
                if (int.Parse(array[i].ToString()) > int.Parse(maxValue.ToString()))
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }
    }
}
