namespace API.Controllers
{
    /// <summary>
    /// Client Groups & Users mapping endpoints. GET, PUT, DELETE
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClientGroupUserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        public ClientGroupUserController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<ClientGroupUserController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<ClientGroupUserEntity> resultObject = await _unitOfWork.ClientGroupUser.GetAll();
            return Ok(resultObject);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ClientGroupUserEntity result = await _unitOfWork.ClientGroupUser.Get(id);
            return Ok(result);
        }

        [HttpGet("usergroups/{id}")]
        public async Task<IActionResult> GetUserClientGroups(int id)
        {
            IEnumerable<ClientGroupUserEntity> result = await _unitOfWork.ClientGroupUser.GetUserAssignedClientGroupsByUserId(id);
            return Ok(result);
        }

        [HttpPut("add")]
        public async Task<IActionResult> Add([FromBody] ClientGroupUserFB clientGroupUser)
        {
            if(!ModelState.IsValid)
                return BadRequest("invalid model.");
            
            try
            {
                var mappedData = _mapper.Map<ClientGroupUserEntity>(clientGroupUser);

                _unitOfWork.ClientGroupUser.Add(mappedData);
                await _unitOfWork.SaveChanges();
                return Ok();
            }
            catch(Exception e)
            {
                _logger.LogError(e, "Adding user to group failed.");
                return StatusCode(500, $"Adding user to group failed. See message below or contact system administrator.\n{e.Message}");
            }
        }

        [HttpPut("addmany")]
        public async Task<IActionResult> Add([FromBody] ClientGroupUsersFB clientGroupUser)
        {
            if (!ModelState.IsValid)
                return BadRequest("invalid model.");
            
            try
            {
                if (clientGroupUser == null || !clientGroupUser.clientGroupUsers.Any()) 
                    return BadRequest("empty collection.");

                var mappedData = _mapper.Map<ClientGroupUserEntity[]>(clientGroupUser.clientGroupUsers);
                _unitOfWork.ClientGroupUser.Add(mappedData);
                await _unitOfWork.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Adding user to multiple groups failed.\n{e.Message}");
                return StatusCode(500, $"Adding user to multiple groups failed. See message below or contact system administrator.\n{ e.Message}");
            }
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int? id = null)
        {
            if(id == null)
                return BadRequest("invalid id recieved.");
            try
            {
                _unitOfWork.ClientGroupUser.Delete((int)id);
                await _unitOfWork.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Delete user grouping failed.\n{e.Message}");
                return StatusCode(500, $"Delete user grouping failed. See message below or contact system administrator.\n{e.Message}");
            }
        }

        [HttpDelete("deletemany")]
        public async Task<IActionResult> Delete([FromBody]IdCollection IdCollection)
        {
            if (!ModelState.IsValid || !IdCollection.Ids.Any())
                return BadRequest("invalid ids recieved.");

            try
            {
                int[] idsToRemove = new int[IdCollection.Ids.Length];
                int counter = 0;
                foreach (var item in IdCollection.Ids)
                {
                    idsToRemove[counter] = item.id;
                    counter++;
                }

                var clientGroupUsers = _unitOfWork.ClientGroupUser.GetAll().Result.Where(x => x.Id.In(idsToRemove));
                _unitOfWork.ClientGroupUser.Delete(clientGroupUsers.ToArray());
                await _unitOfWork.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Delete user from multiple groups failed.\n{e.Message}");
                return StatusCode(500, $"Delete user from multiple groups failed. See message below or contact system administrator\n{e.Message}");
            }
        }
    }
}
