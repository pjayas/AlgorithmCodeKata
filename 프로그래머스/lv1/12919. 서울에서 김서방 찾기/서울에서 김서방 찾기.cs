using System;

public class Solution
    {
        public string solution(string[] seoul)
        {
            return new string($"김서방은 {Array.IndexOf(seoul, "Kim")}에 있다");
        }
    }