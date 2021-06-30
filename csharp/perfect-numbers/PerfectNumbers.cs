using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1)
            throw new ArgumentOutOfRangeException();

        var aliquotSum = CalculateAliquotSum(number);

        return aliquotSum > number ? Classification.Abundant
            : aliquotSum == number ? Classification.Perfect
            : Classification.Deficient;
    }

    private static int CalculateAliquotSum(int number)
    {
        var aliquot = 0;
        for (int i = 1; i <= number / 2; i++)
            if (number % i == 0)
                aliquot += i;
        return aliquot;
    }
}
