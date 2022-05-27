using System;

public class Kata
{
    public static int CountBits(int n)
    {
        int bitCount = 0;
        while (n != 0)
        {
            if (n % 2 != 0)
            {
                bitCount++;
            }
            n /= 2;
        }
        return bitCount;
    }
}