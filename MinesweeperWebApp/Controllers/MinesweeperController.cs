using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using MinesweeperWepApp.MinesweeperApp;

namespace MinesweeperWepApp.Controllers
{
    [Route("api/panel")]
    [ApiController]
    public class MinesweeperController : ControllerBase
    {
        private readonly IMapper _mapper;

        public MinesweeperController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet()]
        public async Task<IActionResult> GetPanel(int width, int height)
        {
            if (width == 0 && height == 0)
                return Ok(new List<RowResource>());

            IList<RowResource> rows = new List<RowResource>();

            await foreach (var row in Minesweeper.GeneratePanelAsync(width, height))
            {
                rows.Add(_mapper.Map<Row, RowResource>(row));
            }

            return Ok(rows);
        }
    }
}
