namespace API.Controllers
{
    /// <summary>
    /// Client Groups endpoints. GET
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Console.Write("Recieve get users request");
            IEnumerable<UserEntity> resultObject = await _unitOfWork.UserRepository.GetAll();
            Console.WriteLine("get users request complete");
            return Ok(resultObject);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            UserEntity result = await  _unitOfWork.UserRepository.Get(id);
            return Ok(result);
        }
    }
}
