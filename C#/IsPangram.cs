/*
 * 6 Kyu - Detect Pangram
 * https://www.codewars.com/kata/545cedaa9943f7fe7b000048
 */

using System;
using System.Linq;

public static class Kata {
    public static bool IsPangram(string str) {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        str = str.ToLower();
        foreach (Char letter in alphabet) {
            if (!str.Contains(letter)) {
                return false;
            }
        }
        return true;
    }
}