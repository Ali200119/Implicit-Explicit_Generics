using System;
namespace Domain
{
	public class DataList<T>
	{
        private T[] array;

        public DataList()
        {
            array = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = data;
        }

        public void GetAll()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}