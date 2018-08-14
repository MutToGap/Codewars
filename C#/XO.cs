/*
 * 7 Kyu - Exes and Ohs
 * https://www.codewars.com/kata/55908aad6620c066bc00002a
 */

using System.Linq;

namespace Codewars {
    public static class Kata {
        public static bool XO(string input) {
            int oCount = input.Count(n => n == 'o' || n == 'O');
            int xCount = input.Count(n => n == 'x' || n == 'X');
            return oCount == xCount;
        }
    }
}
