namespace DotNetPsql.Controllers
{
    [ApiController]
    [Route("/api/persons")]
    public class PersonController : Controller
    {
        private readonly EFCoreContext _dbContext;
        public PersonController(EFCoreContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<Person> Index()
        {
            var persons = _dbContext.Persons.Take(10).ToList();
            return persons;
        }
        [HttpGet("{page:int?}")]
        public List<Person> PaginatedPersons(int? page)
        {
            var persons = _dbContext.Persons.OrderBy(p => p.Id).Skip((page - 1) * 10 ?? 0).Take(10).ToList();
            return persons;
        }
        [HttpGet("cars/{page:int?}")]
        public List<Car?> PaginatedPersonsCars(int? page)
        {
            var cars = _dbContext.Persons.OrderBy(p => p.Id).Skip((page - 1) * 10 ?? 0).Take(10).Select(p => p.Car).Where(c => c != null).ToList();
            return cars;
        }
    }
}