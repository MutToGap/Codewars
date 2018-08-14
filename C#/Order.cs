/*
 * 6 Kyu - Your order, please
 * https://www.codewars.com/kata/55c45be3b2079eccff00010f
 */

using System.Collections.Generic;
using System.Linq;

public static class Kata {
    public static string Order(string words) {
        string result = "";
        List<string> split = words.Split(' ').ToList();
        for (int n = 0; n < split.Count; n++) {
            for (int m = 0; m < split.Count; m++) {
                if (split[m].Contains((n + 1).ToString())) {
                    result += split[m];
                    break;
                }
            }
            result += (n + 1 == split.Count) ? "" : " ";
        }
        return result;
    }
}