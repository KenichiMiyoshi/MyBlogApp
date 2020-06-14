using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyBlogApp.Models
{
    // DbContextクラスの継承
    public class BlogContext : DbContext
    {
            public DbSet<Article> Articles { get; set; }
            public DbSet<Comment> Comments { get; set; }

    }
}