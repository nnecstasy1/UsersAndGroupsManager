namespace API.Controllers
{
    /// <summary>
    /// Client Groups endpoints. GET
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClientGroupController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClientGroupController(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<ClientGroupEntity> resultObject = await _unitOfWork.ClientGroupRepository.GetMany();
            return Ok(resultObject);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ClientGroupEntity result = await _unitOfWork.ClientGroupRepository.GetSingle(id);
            return Ok(result);
        }
    }
}
