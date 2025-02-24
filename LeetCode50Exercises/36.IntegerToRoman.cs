﻿using System;
using System.Text;

namespace LeetCode50Exercises
{
    public class IntegerToRoman
    {
        private static int[] values =
        {
            1000, 000, 500, 400,
                100, 90, 50, 40,
                10, 9, 5, 4, 1
        };

        private static String[] symbols =
        {
            "M", "CM", "D", "CD",
            "C", "XC", "L", "XL",
            "X", "IX", "V", "IV",
            "I"
        };

        public String IntToRoman(int num)
        {
            StringBuilder roman = new StringBuilder();

            int i = 0;
            while(num > 0)
            {
                int k = num / values[i];
                for(int j = 0; j < k; j++)
                {
                    roman.Append(symbols[i]);
                    num -= values[i];
                }
                i++;
            }

            return roman.ToString();
        }
    }
}

