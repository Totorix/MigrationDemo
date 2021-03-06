using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Text;

namespace MigrationDemo
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }

        public string Url { get; set; }
        public int Rating { get; set; }

        public int ColUser1 { get; set; }

        public int User2 { get; set; }
        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        
        [MaxLength(200)]
        public string Title { get; set; }

        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public string Abstract { get; set; }
    }
}
