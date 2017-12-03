using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public static class Day02
    {
        public static void SolvePuzzles()
        {
            SolvePuzzle1();
            SolvePuzzle2();
        }

        private static void SolvePuzzle1()
        {
            var checkSum = 0;
            using (var reader = new StreamReader("Day02Spreadsheet.txt"))
            {
                var text = "";
                while ((text = reader.ReadLine()) != null)
                {
                    var cells = text.Split('\t').Select(int.Parse).OrderBy(i=>i).ToList();
                    checkSum += cells.Last() - cells.First();
                }
            }

            Console.WriteLine($"Day 02 Problem 01 Solution = {checkSum}");
        }

        private static void SolvePuzzle2()
        {
            var checkSum = 0;
            using (var reader = new StreamReader("Day02Spreadsheet.txt"))
            {
                var text = "";
                while ((text = reader.ReadLine()) != null)
                {
                    var cells = text.Split('\t').Select(int.Parse).OrderByDescending(i => i).ToList();
                    for (var x=0; x < cells.Count(); x++)
                    {
                        for (var y = x+1; y < cells.Count(); y++)
                        {
                            if (y == cells.Count()) break;
                            if (cells[x] % cells[y] == 0)
                            {
                                checkSum += cells[x] / cells[y];
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Day 02 Problem 02 Solution = {checkSum}");
        }
    }
}
