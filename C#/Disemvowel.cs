/*
 * 7 Kyu - Disemvowel Trolls
 * https://www.codewars.com/kata/52fba66badcd10859f00097e
 */

using System;

public static class Kata {
    public static string Disemvowel(string str) {
        foreach (Char c in "aeiouAEIOU") { str = str.Replace(c.ToString(), ""); }
        return str;
    }
}