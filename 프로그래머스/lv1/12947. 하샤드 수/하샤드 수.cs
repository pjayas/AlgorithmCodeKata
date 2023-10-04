using System;

public class Solution
    {
        public bool solution(int x)
        {
        // x를 문자열로 변환한다.
            string temp = x.ToString();
            // for문을 돌려서 각 자리수의 합을 구한다.
            int sum = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                sum += (int)Char.GetNumericValue(temp[i]);
            }
            // x가 자리수 합으로 나눠떨어지면 참, 아니면 거짓
            bool answer = x % sum==0 ? true:false;
            return answer;
        }
    }