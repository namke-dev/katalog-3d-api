using katalog_3d_api.entities;
using katalog_3d_api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace katalog_3d_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfferedServiceController(IRepository<OfferedService> repository) : GenericController<OfferedService>(repository)
    {

    }
}