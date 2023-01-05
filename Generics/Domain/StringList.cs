namespace Domain;
public class StringList
{
    private string[] array;

    public StringList()
    {
        array = new string[0];
    }

    public void Add(string str)
    {
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = str;
    }

    public void GetAll()
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}