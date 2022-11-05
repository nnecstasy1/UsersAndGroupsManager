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
            IEnumerable<ClientGroupUserEntity> resultObject = await _unitOfWork.ClientGroupUserRepository.GetAll();
            return Ok(resultObject);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ClientGroupUserEntity result = await _unitOfWork.ClientGroupUserRepository.Get(id);
            return Ok(result);
        }

        [HttpGet("usergroups/{id}")]
        public async Task<IActionResult> GetUserClientGroups(int id)
        {
            IEnumerable<ClientGroupUserEntity> result = await _unitOfWork.ClientGroupUserRepository.GetUserAssignedClientGroupsByUserId(id);
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

                _unitOfWork.ClientGroupUserRepository.Add(mappedData);
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
        public async Task<IActionResult> Add([FromBody] ClientGroupUserFB[] clientGroupUser)
        {
            if (!ModelState.IsValid)
                return BadRequest("invalid model.");
            
            try
            {
                if (clientGroupUser == null || !clientGroupUser.Any()) 
                    return BadRequest("empty collection.");

                var mappedData = _mapper.Map<ClientGroupUserEntity[]>(clientGroupUser);
                _unitOfWork.ClientGroupUserRepository.Add(mappedData);
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
                _unitOfWork.ClientGroupUserRepository.Delete((int)id);
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
        public async Task<IActionResult> Delete([FromBody] ClientGroupUserFB[] clientGroupUser)
        {
            if (!ModelState.IsValid)
                return BadRequest("invalid ids recieved.");

            try
            {
                var result = _unitOfWork.ClientGroupUserRepository.GetAll().Result.ToList();
                if(result == null)
                {
                    return Ok();
                }

                List<ClientGroupUserEntity> clientGroupEntities = new List<ClientGroupUserEntity>();
                foreach (var a in clientGroupUser)
                {
                    foreach (var b in result)
                    {
                        if (b.UserId == a.UserId && b.ClientGroupId == a.ClientGroupId)
                        {
                            clientGroupEntities.Add(b);
                            //narrow down the data on following iteration
                            if(clientGroupUser.Length > 1) result.Remove(b);
                            break;
                        }
                    }
                }

                _unitOfWork.ClientGroupUserRepository.Delete(clientGroupEntities.ToArray());
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
