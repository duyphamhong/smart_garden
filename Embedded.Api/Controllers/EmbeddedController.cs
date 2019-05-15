using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Embedded.Api.Model;
using Embedded.Api.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Embedded.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmbeddedController : ControllerBase
    {
        private readonly EmbeddedContext _embeddedContext;

        public EmbeddedController(EmbeddedContext embeddedContext)
        {
            _embeddedContext = embeddedContext;
        }

        // GET api/v1/[controller]/items[?pageSize=3&pageIndex=10]
        [HttpGet]
        [Route("groundHumidities")]
        [ProducesResponseType(typeof(PaginatedItemsViewModel<GroundHumidity>), (int) HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<GroundHumidity>), (int) HttpStatusCode.OK)]
        [ProducesResponseType((int) HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GroundHumiditiesAsync([FromQuery] int pageSize = 10, [FromQuery] int pageIndex = 0,
            string ids = null)
        {
            var totalItems = await _embeddedContext.GroundHumidities
                .LongCountAsync();

            var itemsOnPage = await _embeddedContext.GroundHumidities
                .OrderBy(c => c.CreatedDate)
                .Skip(pageSize * pageIndex)
                .Take(pageSize)
                .ToListAsync();

            var model = new PaginatedItemsViewModel<GroundHumidity>(pageIndex, pageSize, totalItems, itemsOnPage);

            return Ok(model);
        }

        // GET api/v1/[controller]/items/withname/samplename[?pageSize=3&pageIndex=10]
        [HttpGet]
        [Route("groundHumidities/userId/{userId:minlength(1)}")]
        [ProducesResponseType(typeof(PaginatedItemsViewModel<GroundHumidity>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<PaginatedItemsViewModel<GroundHumidity>>> ItemsWithNameAsync(int userId, [FromQuery]int pageSize = 10, [FromQuery]int pageIndex = 0)
        {
            var totalItems = await _embeddedContext.GroundHumidities
                .Where(c => c.CustomerId.Equals(userId))
                .LongCountAsync();

            var itemsOnPage = await _embeddedContext.GroundHumidities
                .Where(c => c.CustomerId.Equals(userId))
                .Skip(pageSize * pageIndex)
                .Take(pageSize)
                .ToListAsync();

            return new PaginatedItemsViewModel<GroundHumidity>(pageIndex, pageSize, totalItems, itemsOnPage);
        }
    }
}