/*
 * 6 Kyu - Equal Sides Of An Array
 * https://www.codewars.com/kata/5679aa472b8f57fb8c000047
 */

using System.Linq;

public class Kata {
    public static int FindEvenIndex(int[] arr) {
        for (int n = 0; n < arr.Length; n++) {
            int leftCount = 0, rightCount = 0, border = n;
            if (border == 0 && arr.Sum() == 0) {
                return 0;
            } else {
                for (int l = 0; l < border; l++) { leftCount += arr[l]; }
                for (int r = border + 1; r < arr.Length; r++) { rightCount += arr[r]; }
                if (leftCount == rightCount)
                    return n;
            }
        }
        return -1;
    }
}