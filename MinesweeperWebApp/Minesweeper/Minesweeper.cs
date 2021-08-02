using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MinesweeperWepApp.MinesweeperApp
{
    public static class Minesweeper
    {
        /// <summary>
        /// Generates a list of rows.
        /// </summary>
        /// <param name="columnsCount">Columns count</param>
        /// <param name="rowsCount">Rows count</param>
        /// <returns></returns>
        public async static IAsyncEnumerable<Row> GeneratePanelAsync(int columnsCount, int rowsCount)
        {
            for (int rowIndex = 1; rowIndex <= rowsCount; rowIndex++)
            {
                int counter = rowIndex + 1;
                int bombIndex = 1;

                var row = new Row();

                for (int columnIndex = 1; columnIndex <= columnsCount; columnIndex++)
                {
                    var location = new Location(rowIndex, columnIndex);
                    bool hasBomb = false;

                    if (columnIndex == bombIndex)
                    {
                        bombIndex += counter;
                        hasBomb = true;
                    }

                    var cell = new Cell(location, hasBomb);
                    row.Cells.Add(cell);
                }

                yield return row;
            }
        }
    }
}