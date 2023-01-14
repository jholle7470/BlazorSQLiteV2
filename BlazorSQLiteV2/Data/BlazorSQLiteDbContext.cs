using Microsoft.EntityFrameworkCore;

namespace BlazorSQLiteV2.Data
{
    public class BlazorSQLiteDbContext : DbContext
    {
        public DbSet<Post>Posts { get; set; }
        public DbSet<PostPicture> PostPictures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=BlazorSQLiteDB.db");

    }
}