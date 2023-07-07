namespace Codewars;

public static class Bus
{
    public static int Enough(int cap, int on, int wait)
    {
        int b = on + wait - cap;
        if (on + wait <= cap)
        {
            return 0;
        }
        else
        {
            return b;
        }
        throw new NotImplementedException();
    }
}