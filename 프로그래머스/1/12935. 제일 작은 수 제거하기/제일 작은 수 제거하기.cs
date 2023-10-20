using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return new int[] { -1 }; // 배열의 길이가 1 이하인 경우 -1을 포함한 배열 반환
        }

        int min = arr.Min(); // 배열에서 가장 작은 수 찾기
        int[] result = arr.Where(num => num != min).ToArray(); // 최소값을 제외한 배열 생성

        return result;
    }
}
