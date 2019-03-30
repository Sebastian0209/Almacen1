using System.Data.Entity;

namespace MVC_Parcial.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC_Parcial.Models.Product> Products { get; set; }
    }
}