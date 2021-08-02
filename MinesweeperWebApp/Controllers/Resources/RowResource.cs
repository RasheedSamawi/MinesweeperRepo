using System.Collections.Generic;

namespace MinesweeperWepApp.Controllers
{
    public class RowResource
    {
        public ICollection<CellResource> Cells { get; set; } = new List<CellResource>();
    }
}