using Domain;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.ApplicationDbContext context)
        {
            var userId = string.Empty;
            if (context.Roles.Count() == 0)
            {
                context.Roles.Add(new IdentityRole("Admin"));

                context.Roles.Add(new IdentityRole("User"));
                context.SaveChanges();
                var manager = new ApplicationUserManager(new UserStore<User>(context));
                var testUser = new User() { UserName = "admin" };

                manager.Create(testUser, "!College83");
                userId = testUser.Id;
                context.SaveChanges();
                manager.AddToRole(userId, "Admin");
                context.SaveChanges();
            }

            /* Products */
            context.Products.AddOrUpdate(
                new Product { ProductId = 1, UserId = userId, Name = "Nimi1" },
                new Product { ProductId = 2, UserId = userId, Name = "Nimi2" }
              );
            context.SaveChanges();
            /* Comments */
            context.Comments.AddOrUpdate(
                new Comment { CommentId = 1, ProductId = 1, CommentText = "Comment1" },
                 new Comment { CommentId = 2, ProductId = 1, CommentText = "Comment2" },
                 new Comment { CommentId = 3, ProductId = 2, CommentText = "Comment1" },
                 new Comment { CommentId = 4, ProductId = 2, CommentText = "Comment2" }
                 );
            context.SaveChanges();


        }
    }
}
