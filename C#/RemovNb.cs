/*
 * 5 Kyu - Is my friend cheating?
 * https://www.codewars.com/kata/5547cc7dcad755e480000004
 */

using System.Collections.Generic;

public class RemovedNumbers {
    public static List<long[]> removNb(long n) {
        List<long[]> result = new List<long[]>();
        long sum = n * (n + 1) / 2;
        for (int j = 1; j <= n; j++) {
            long a = (sum - j) / (j + 1);
            if (a * j + a + j == sum && a < n) {
                result.Add(new long[] { j, a });
            }
        }
        return result;
    }
}