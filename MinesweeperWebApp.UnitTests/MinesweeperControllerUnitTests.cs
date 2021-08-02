using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MinesweeperWepApp.Mapping;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using MinesweeperWepApp.Controllers;

namespace MinesweeperWepApp.UnitTests
{
    public class MinesweeperControllerUnitTests
    {
        private MinesweeperController _controller;

        [SetUp]
        public void Setup()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = new Mapper(mapperConfig);

            _controller = new MinesweeperController(mapper);
        }

        [Test]
        public async Task GetPanel_DontPassParameters_GetAnEmptyPanel()
        {
            IActionResult result = await _controller.GetPanel(width: 0, height: 0);

            var okResult = result as OkObjectResult;

            Assert.That(okResult, Is.Not.Null);
            Assert.That(okResult.StatusCode, Is.EqualTo(200));

            var rows = okResult.Value as ICollection<RowResource>;

            Assert.That(rows, Is.Not.Null);
            Assert.That(rows.Count, Is.EqualTo(0));
        }

        [TestCase(3, 3)]
        [TestCase(4, 4)]
        public async Task GetPanel_ReturnPanelRows(int width, int height)
        {
            IActionResult result = await _controller.GetPanel(width, height);

            var okResult = result as OkObjectResult;

            Assert.That(okResult, Is.Not.Null);
            Assert.That(okResult.StatusCode, Is.EqualTo(200));

            var rows = okResult.Value as ICollection<RowResource>;

            Assert.That(rows, Is.Not.Null);
            Assert.That(rows.Count, Is.EqualTo(height));

            foreach (var row in rows)
            {
                Assert.That(row.Cells.Count, Is.EqualTo(width));
            }
        }
    }
}