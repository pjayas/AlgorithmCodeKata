using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        int total = 45; // 0부터 9까지의 숫자의 합은 45입니다.

        foreach (int num in numbers)
        {
            total -= num;
        }

        return total;
    }
}