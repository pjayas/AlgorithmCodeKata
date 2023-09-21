using System;

public class Solution {
    public long solution(long n) {
        if (n <= 0) {
            return -1;
        }
        
        double sqrt = Math.Sqrt(n);
        if (sqrt == (int)sqrt) {
            int x = (int)sqrt;
            return (long)Math.Pow(x + 1, 2);
        } else {
            return -1;
        }
    }
}
