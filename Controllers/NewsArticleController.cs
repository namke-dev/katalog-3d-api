using katalog_3d_api.entities;
using katalog_3d_api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace katalog_3d_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsArticleController(IRepository<NewsArticle> repository) : GenericController<NewsArticle>(repository)
    {

    }
}