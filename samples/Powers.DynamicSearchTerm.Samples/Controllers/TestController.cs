using Microsoft.AspNetCore.Mvc;
using Powers.DynamicSearchTerm.Samples.Shared;
using Powers.DynamicSearchTerm.Extensions;

namespace Powers.DynamicSearchTerm.Samples.Controllers
{
    [ApiController]
    [Route("api/[Controller]/[Action]")]
    public class TestController : ControllerBase
    {
        private readonly IEnumerable<User> _users;

        public TestController()
        {
            _users = new List<User>()
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "A-Name",
                    Account = "A-Account",
                    Password = "A-Password",
                    Birthday = new DateTime(2000, 1, 1),
                    Age = 18,
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "B-Name",
                    Account = "B-Account",
                    Password = "B-Password",
                    Birthday = new DateTime(2005, 1, 1),
                    Age = 24,
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "C-Name",
                    Account = "C-Account",
                    Password = "C-Password",
                    Birthday = new DateTime(2010, 1, 1),
                    Age = 30,
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "D-Name",
                    Account = "D-Account",
                    Password = "D-Password",
                    Birthday = new DateTime(2015, 1, 1),
                    Age = 40,
                },
            };
        }

        [HttpGet]
        public IActionResult GetUsers(string? query)
        {
            var users = _users.AsQueryable().ApplyDynamicSearch(query ?? "").ToList();

            return Ok(users);
        }
    }
}