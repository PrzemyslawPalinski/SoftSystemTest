// See https://aka.ms/new-console-template for more information
using SoftSystemTest;

int[,] sudoku = {  {1,5,7,4,8,3,6,2,9},
                   {6,3,8,1,2,9,7,5,4},
                   {4,9,2,5,6,7,1,3,8},
                   {8,4,5,9,7,6,3,1,2},
                   {7,2,1,3,5,8,9,4,6},
                   {3,6,9,2,1,4,5,8,7},
                   {5,1,6,7,4,2,8,9,3},
                   {2,8,3,6,9,1,4,7,5},
                   {9,7,4,8,3,5,2,6,1}};

var rand = new Random();
int numer = rand.Next(1, 3999);
Zad1 zad1 = new Zad1();
Zad2 zad2 = new Zad2();
Zad3 zad3 = new Zad3();
Console.WriteLine("Number passed is {0} and closest perfect square is {1}",numer, zad1.PerfectSquare(numer));

Console.WriteLine("Number converted is {0} and representation is {1}",numer,zad2.ConvertToRomanNumeral(numer));
Console.WriteLine("Is sudoku correct? {0}", zad3.IsSudokuCorrect(sudoku));
Console.ReadKey();