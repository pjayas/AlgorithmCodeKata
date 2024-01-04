using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);
        
        //이중 반복으로 *을 Console.Write() 후 한번 반복 끝나면 Console.WriteLine()으로 엔터
        for(int i=0; i<b; i++)
        {
            for(int j=0; j<a; j++)
            {
                Console.Write("*");        
            }
            Console.WriteLine();
        }
        
    }
}