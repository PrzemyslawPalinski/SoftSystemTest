using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftSystemTest
{
    internal class Zad3
    {
        internal bool IsSudokuCorrect(int[,] sudoku)
        {

            HashSet<int>[] uniqueSector = new HashSet<int>[9];
            for (int i = 0; i < uniqueSector.Length; i++)
            {
                uniqueSector[i] = new HashSet<int>();
            }
            for (int i = 0; i < 9; i++)
            {
                HashSet<int> uniqueRow = new HashSet<int>();
                HashSet<int> uniqueCol = new HashSet<int>();
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i,j] != 0) if (!uniqueRow.Add(sudoku[i,j])) return false;
                    if (sudoku[j,i] != 0) if (!uniqueCol.Add(sudoku[j,i])) return false;
                    if (Enumerable.Range(0, 3).Contains(i) && Enumerable.Range(0, 3).Contains(j)) if (sudoku[i, j] != 0) if (!uniqueSector[0].Add(sudoku[j, i])) return false;
                    if (Enumerable.Range(3, 3).Contains(i) && Enumerable.Range(0, 3).Contains(j)) if (sudoku[i, j] != 0) if (!uniqueSector[1].Add(sudoku[j, i])) return false;
                    if (Enumerable.Range(6, 3).Contains(i) && Enumerable.Range(0, 3).Contains(j)) if (sudoku[i, j] != 0) if (!uniqueSector[2].Add(sudoku[j, i])) return false;
                    if (Enumerable.Range(0, 3).Contains(i) && Enumerable.Range(3, 3).Contains(j)) if (sudoku[i, j] != 0) if (!uniqueSector[3].Add(sudoku[j, i])) return false;
                    if (Enumerable.Range(0, 3).Contains(i) && Enumerable.Range(6, 3).Contains(j)) if (sudoku[i, j] != 0) if (!uniqueSector[4].Add(sudoku[j, i])) return false;
                    if (Enumerable.Range(3, 3).Contains(i) && Enumerable.Range(3, 3).Contains(j)) if (sudoku[i, j] != 0) if (!uniqueSector[5].Add(sudoku[j, i])) return false;
                    if (Enumerable.Range(6, 3).Contains(i) && Enumerable.Range(6, 3).Contains(j)) if (sudoku[i, j] != 0) if (!uniqueSector[6].Add(sudoku[j, i])) return false;
                    if (Enumerable.Range(6, 3).Contains(i) && Enumerable.Range(3, 3).Contains(j)) if (sudoku[i, j] != 0) if (!uniqueSector[7].Add(sudoku[j, i])) return false;
                    if (Enumerable.Range(3, 3).Contains(i) && Enumerable.Range(6, 3).Contains(j)) if (sudoku[i, j] != 0) if (!uniqueSector[8].Add(sudoku[j, i])) return false;
                }
            }
            return true;
        }
    }
}
