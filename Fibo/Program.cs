using System;
using static System.Console;
class MyClass
{
    static void Main()
    {
        Write("Write your number - ");
        int size = Convert.ToInt16( ReadLine() );
        List <int> arr = new List<int>(0);
        arr.Add(0);
        arr.Add(1);
        int buf_f = 0;
        for (int i = 2; i < size; i++)
        {
            int buf_l = arr.Last();
            int buf = buf_l;
            arr.Add(buf_f + buf_l);
            buf_f = buf;
        }
        Write("Fibo: ");
        foreach (int i in arr)
        {
            Write($"{i} ");
        }  
    }
}