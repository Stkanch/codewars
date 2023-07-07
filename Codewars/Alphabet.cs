namespace Codewars;

public class Alphabet
{
    public static string Position(char alphabet)
    {
        int a = alphabet - (int)'a' + 1;
        return "Position of alphabet: " + a;
    }
}