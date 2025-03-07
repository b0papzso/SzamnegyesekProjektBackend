using Microsoft.EntityFrameworkCore;

namespace SzamnegyesekProjekt.Context
{
    public class FoursContext : DbContext
    {
        public FoursContext(DbContextOptions<FoursContext> options) : base(options)
        {
        }
    }
}
