using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftSystemTest
{
    internal class Zad2
    {
        internal string ConvertToRomanNumeral(int year)
        {
            StringBuilder sb = new StringBuilder();
            while (year > 0)
            {
                switch (year)
                {
                    case >= 1000: sb.Append("M"); year -= 1000; break;
                    case >= 900 and < 1000: sb.Append("CM"); year -= 900; break;
                    case >= 500: sb.Append("D"); year -= 500; break;
                    case >= 400 and < 500: sb.Append("CD"); year -= 400; break;
                    case >= 100: sb.Append("C"); year -= 100; break;
                    case >= 90 and < 100:  sb.Append("XC"); year -= 90; break;
                    case >= 50: sb.Append("L"); year -= 50; break;
                    case >= 40 and < 50: sb.Append("XL"); year -= 40; break;
                    case >= 10: sb.Append("X"); year -= 10; break;
                    case 9: sb.Append("IX"); year -= 9; break;
                    case >= 5: sb.Append("V"); year -= 5; break;
                    case 4: sb.Append("IV"); year -= 4; break;
                    default: sb.Append("I"); year -= 1; break;
                }               
            }
            return sb.ToString();
        }
    }
}
