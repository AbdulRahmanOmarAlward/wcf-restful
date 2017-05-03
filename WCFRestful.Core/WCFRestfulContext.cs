using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFRestFull.Core.Configurations;

namespace WCFRestFull.Core
{
    public class WCFRestfulContext : DbContext
    {
        public WCFRestfulContext()
            : base("WCFRestfulContext")
        {
            Database.SetInitializer<WCFRestfulContext>(null);
        }

        public DbSet<Blog> BlogSet { get; set; }
        public DbSet<Article> ArticleSet { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ArticleConfiguration());
            modelBuilder.Configurations.Add(new BlogConfiguration());
        }
    }
}
