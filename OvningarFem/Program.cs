// See https://aka.ms/new-console-template for more information

using DataAccess2;
using DataAccess2.Entities2;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");


using var blogContext = new AppDbContext();

//blogContext.Blogs.Add(
//    new()
//    {
//        Title = "Livet på ITHS",
//        Content = "Livet på ITHS är super kul!"
//    });

//blogContext.Blogs.Add(
//    new()
//    {
//        Title = "Livet är svårt",
//        Content = "Jag undrar hur man gör för att andas?"
//    });

//blogContext.SaveChanges();

//var joeAuthor = new Author() { Name = "Joseph" };

//blogContext.Authors.Add(joeAuthor);

//blogContext.SaveChanges();

//var joeAuthor = blogContext
//    .Authors
//    .Include(a => a.BlogPosts)
//    .FirstOrDefault(a => a.Id == 1);

//var post1 = blogContext.Blogs.Find(1);
//var post2 = blogContext.Blogs.Find(2);

//joeAuthor.BlogPosts.Add(post1);
//joeAuthor.BlogPosts.Add(post2);

//blogContext.SaveChanges();

//var post1 = blogContext
//    .Blogs
//    .Include(b => b.Comments)
//    .FirstOrDefault(b => b.Id == 1);

//var post2 = blogContext
//    .Blogs
//    .Include(b => b.Comments)
//    .FirstOrDefault(b => b.Id == 2);


//var comment1 = new Comment() { CommentContent = "LOL!" };
//var comment2 = new Comment() { CommentContent = "HAHAHA!" };

//var comment3 = new Comment() { CommentContent = "OMG BRO!" };

//post1.Comments.Add(comment1);
//post1.Comments.Add(comment2);

//post2.Comments.Add(comment3);

//blogContext.SaveChanges();



