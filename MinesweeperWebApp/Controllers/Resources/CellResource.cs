namespace MinesweeperWepApp.Controllers
{
    public class CellResource
    {
        public LocationResource Location { get; set; }
        public bool HasBomb { get; set; }
    }
}
