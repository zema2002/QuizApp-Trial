using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication2.DataBase;

namespace WebApplication2.DataBase
{
    public class QuestionsContext : DbContext
    {
       
        public DbSet<Question> Questions { get; set; }
        public QuestionsContext(DbContextOptions<QuestionsContext> options)
            : base(options)
        {
           
        }

        public QuestionsContext()
        {
        }
    }

}
