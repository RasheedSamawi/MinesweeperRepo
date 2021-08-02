using System;

namespace MinesweeperWepApp.MinesweeperApp
{
    public class Cell
    {
        public Location Location { get; }
        public bool HasBomb { get; }

        public Cell(Location location, bool hasBomb)
        {
            Location = location ?? throw new ArgumentNullException(nameof(location));
            HasBomb = hasBomb;
        }
    }
}