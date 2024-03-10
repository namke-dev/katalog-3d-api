using katalog_3d_api.entities;
using katalog_3d_api.Repository;
using Microsoft.AspNetCore.Mvc;


namespace katalog_3d_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : GenericController<User>
    {
        public UserController(IRepository<User> repository) : base(repository)
        {
        }
    }
}