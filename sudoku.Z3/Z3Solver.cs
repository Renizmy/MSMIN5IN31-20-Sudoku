using Sudoku.Core;
using System;
using System.Collections.Generic;

using Microsoft.Z3;
using System.Linq;
using Z3.LinqBinding.Sudoku;
using Z3.LinqBinding;
using System.Globalization;

namespace sudoku.Z3
{

    public class Z3Solver : ISudokuSolver
    {
        public Sudoku.Core.Sudoku Solve(Sudoku.Core.Sudoku s)
        {
            /*
            SudokuAsArray sudokuAsArray = new SudokuAsArray();
            Z3Context z3Context = new Z3Context();
            String list = "";
            sudokuAsArray.CreateTheorem(z3Context);

            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                   list += s.GetCell(i, j);
                }
            }


            var a = z3Context.NewTheorem(SudokuAsArray.Parse(list)).Solve();
            list ="";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    list = a.Cells[i * 9 + j].ToString();
                }
            }


            // z3Context.CreateContext();
            // SudokuAsArray a = sudokuAsArray.CreateTheorem(z3Context).Solve() ;            


            return Sudoku.Core.Sudoku.Parse(list);
            */
           return new Z3Context().NewTheorem(s).Solve;


        }
    }
}

