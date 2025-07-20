using System;

public class StringIndexers
{
    private string[] newArr = new string[10];

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= newArr.Length)
                throw new IndexOutOfRangeException("Index is out of range.");

            return newArr[index];
        }

        set
        {
            if (index < 0 || index >= newArr.Length)
                throw new IndexOutOfRangeException("Index is out of range.");

            newArr[index] = value; 
        }
    }
}
