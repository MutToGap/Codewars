/*
 * 7 Kyu - Square Every Digit
 * https://www.codewars.com/kata/546e2562b03326a88e000020
 */

using System;
using System.Linq;

public static class Kata {
    public static int SquareDigits(int n) {
        string result = "";
        n.ToString().ToList().ForEach(x => result += Math.Pow(Int32.Parse(x.ToString()), 2).ToString());
        return Int32.Parse(result);
    }
}
