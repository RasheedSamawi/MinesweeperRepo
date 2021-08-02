using System.Collections.Generic;

namespace MinesweeperWepApp.MinesweeperApp
{
    public class Row
    {
        public ICollection<Cell> Cells { get; set; } = new List<Cell>();
    }
}