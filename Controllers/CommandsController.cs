using System.Collections.Generic;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;
using Commander.Data;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
    
        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        // private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        // GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var CommandItems = _repository.GetAppCommands();

            return Ok(CommandItems);
        }

        // GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var CommandItem = _repository.GetCommandById(id);

            return Ok(CommandItem);
        }
    }
}