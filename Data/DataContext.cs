using System;
using Microsoft.EntityFrameworkCore;
using ArticleAPp.API.Models;
namespace ArticleAPp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {}

        public DbSet<Article> Articles{get;set;}
    }
}