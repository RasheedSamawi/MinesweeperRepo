using System;

namespace MinesweeperWepApp.MinesweeperApp
{
    public class Location
    {
        public int Row { get; }
        public int Column { get; }

        public Location(int row, int column)
        {
            if (row == 0)
                throw new ArgumentException("row is required", nameof(row));

            if (column == 0)
                throw new ArgumentException("column is required", nameof(column));

            Row = row;
            Column = column;
        }
    }
}