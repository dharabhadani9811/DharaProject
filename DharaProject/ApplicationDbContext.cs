using DharaProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DharaProject
{
    public class ApplicationDbContext   : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<UserModel> _dbSetUser { get; set; }
        public DbSet<ProductModel>_dbSetProducts { get; set; }
        public DbSet<OrderModel> _dbSetOrder { get; set; }
        public DbSet<Cart> _dbSetCart { get; set; }
        public DbSet<CategoryModel> _dbSetCategory { get; set; }
        public DbSet<OrderDetails> _dbSetOrderDetails { get; set; }

    }
}
