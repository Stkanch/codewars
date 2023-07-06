namespace Codewars;

public class Letter
{
    public static int StrCount(string str, char letter)
    {
        int a = str.Split(letter).Length-1;
        return a; 
    }
}