﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode415
    {
        public static string AddStrings(string num1,string num2)
        {
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            for(int i=num1.Length-1,j=num2.Length-1;i>=0||j>=0||carry==1;i--,j--)
            {
                int x = i < 0 ? 0 : num1[i] - '0';
                int y = j < 0 ? 0 : num2[j] - '0';
                sb.Append((x + y + carry) % 10);
                carry = (x + y + carry) / 10;
            }

            char[] temp = sb.ToString().ToCharArray();
            Array.Reverse(temp);
            return new string( temp );

        }
    }
}
