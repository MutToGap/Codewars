/*
 * 6 Kyu - Duplicate Encoder
 * https://www.codewars.com/kata/54b42f9314d9229fd6000d9c
 */

using System;
using System.Linq;

public class Kata {
    public static string DuplicateEncode(string word) {
        string result = "";
        word = word.ToLower();
        foreach (Char c in word) {
            result += (word.Count(f => f == c) > 1 ? ")" : "(");
        }
        return result;
    }
}