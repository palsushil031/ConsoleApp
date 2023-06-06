using System;
public class Anagram
{
    public static void AnagramMethod()
    {
        string str1 = "hello";
        string str2 = "holee";

        char[] charArry1 = str1.ToLower().ToCharArray();
        char[] charArry2 = str2.ToLower().ToCharArray();

        Array.Sort(charArry1);
        Array.Sort(charArry2);

        string st1 = new string(charArry1);
        string st2 = new string(charArry2);

        if (st1 == st2)
        {
            Console.WriteLine("String is Anagram!");
        }
        else
        {
            Console.WriteLine("string is Not anagram!");
        }
    }

}