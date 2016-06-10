








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
                new Product { ProductId = 1, UserId = userId, Title = "Nimi1", Intro = "Intro1", Body = "Body1", Hidden = false, Created = DateTime.Now },
                new Product { ProductId = 2, UserId = userId, Title = "Nimi2", Intro = "Intro2", Body = "Body2", Hidden = false, Created = DateTime.Now }
              );
            context.SaveChanges();
            /* Comments */
            context.Comments.AddOrUpdate(
                new Comment { CommentId = 1, ProductId = 1, Title = "Comment1", Author = "Author1", Body = "CommentBody1", Created = DateTime.Now },
                 new Comment { CommentId = 2, ProductId = 1, Title = "Comment2", Author = "Author2", Body = "CommentBody2", Created = DateTime.Now },
                 new Comment { CommentId = 3, ProductId = 2, Title = "Comment3", Author = "Author3", Body = "CommentBody3", Created = DateTime.Now },
                 new Comment { CommentId = 4, ProductId = 2, Title = "Comment4", Author = "Author4", Body = "CommentBody4", Created = DateTime.Now }
                 );
            context.SaveChanges();


        }
    }
}
