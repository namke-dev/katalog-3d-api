using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using katalog_3d_api.entities;
using katalog_3d_api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace katalog_3d_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserProfileController(IRepository<UserProfile> repository) : GenericController<UserProfile>(repository)
    {
    }
}