using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftSystemTest
{
    internal class Zad1
    {
        internal int PerfectSquare(int startingNumber)
        {
            int closestPerfectSquare = 0;
            while(closestPerfectSquare == 0)
            {
                if(Math.Sqrt(startingNumber)%1==0) closestPerfectSquare = startingNumber;
                else startingNumber++;
            }
            return closestPerfectSquare;
        }
    }
}