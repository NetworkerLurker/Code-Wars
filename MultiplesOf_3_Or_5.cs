public static class Kata
{
    public static int Solution(int value)
    {

        int total = 0;
        int currentNumber3 = 0;
        int currentNumber5 = 0;

        while (currentNumber3 < value)
        {
            total += currentNumber3;
            currentNumber3 += 3;
        }

        while (currentNumber5 < value)
        {
            if (currentNumber5 % 3 != 0)
            {
                total += currentNumber5;
                currentNumber5 += 5;
            }
            else
            {
                currentNumber5 += 5;
            }
        }

        return total;

    }
}