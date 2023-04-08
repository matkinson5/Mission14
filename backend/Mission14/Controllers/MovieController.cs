using Microsoft.AspNetCore.Mvc;
using Mission14.Data;
using static System.Reflection.Metadata.BlobBuilder;

namespace Mission14.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MovieDbContext context;

        public MovieController(MovieDbContext temp)
        {
            context= temp;
        }
        public IEnumerable<MovieInfo> Get()
        {
            var x = context.Movies.ToArray()
                .Where(m => m.Edited == "Yes")
                .OrderBy(m => m.Title);
                
            return x;
        }
    }
}
