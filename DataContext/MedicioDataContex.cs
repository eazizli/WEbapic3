using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5.DataContext
{
    public class MedicioDataContex:DbContext
    {
        public MedicioDataContex(DbContextOptions<MedicioDataContex> options) :base(options)
        {

        }
      public  DbSet<Service> Services { get; set; }
    }
}
