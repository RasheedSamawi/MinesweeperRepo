using System.Collections.Generic;

namespace MinesweeperWepApp.Controllers
{
    public class MinesweeperResource
    {
        public int Width { get; set; }
        public IEnumerable<CellResource> Cells { get; set; }
    }
}
