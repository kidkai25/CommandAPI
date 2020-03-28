using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        public CommandsController()
        {
            var x = 0;
        }
        [HttpPost]
        public ActionResult<IEnumerable<string>> GetCommandItems()
        {
            return new string[]{"this", "is", "hard", "coded"};
        }
    }
}