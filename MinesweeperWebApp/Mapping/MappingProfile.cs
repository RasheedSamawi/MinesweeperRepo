using AutoMapper;
using MinesweeperWepApp.Controllers;
using MinesweeperWepApp.MinesweeperApp;

namespace MinesweeperWepApp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Row, RowResource>();
            CreateMap<Location, LocationResource>();
            CreateMap<Cell, CellResource>();
        }
    }
}
