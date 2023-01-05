using System;
namespace Domain;

public class IntList
{
    private int[] array;

    public IntList()
    {
        array = new int[0];
    }

    public void Add(int num)
    {
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = num;
    }

    public void GetAll()
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}