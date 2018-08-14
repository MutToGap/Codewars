/*
 * 6 Kyu - Find The Parity Outlier
 * https://www.codewars.com/kata/5526fc09a1bbd946250002dc
 */

using System.Collections.Generic;

public class Kata {
    public static int Find(int[] integers) {
        List<int> odd = new List<int>(), even = new List<int>();
        foreach (int n in integers) {
            ((n % 2 == 0) ? even : odd).Add(n);
        }
        return odd.Count < even.Count ? odd[0] : even[0];
    }
}