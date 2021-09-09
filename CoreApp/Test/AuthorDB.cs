using CoreApp.DAL.Data;
using DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using TestSupport.EfHelpers;
using TestSupport.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace Test
{
    public class AuthorDB
    {

        [Fact]
        public void AddAuthorToDatabase()
        {

            //SETUP
            var con = this.GetUniqueDatabaseConnectionString();
            var options = this.CreateUniqueClassOptions<ApplicationDbContext>();
            using var context = new ApplicationDbContext(options);
            context.Database.EnsureClean();

            Author a1 = Author.CreateAuthor("Lydia Sandgren");
            context.Add(a1);
            var result = context.SaveChanges();
            Assert.True(result == 1);
        }
    }
}
