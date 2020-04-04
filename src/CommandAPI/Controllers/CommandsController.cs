using System.Collections.Generic;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly CommandContext _context;
        
        public CommandsController(CommandContext commandContext)
        {
            _context = commandContext;
        }
        [HttpPost]
        public ActionResult<IEnumerable<Command>> GetCommandItems()
        {
            return _context.CommandItems;   
        }
    }
}