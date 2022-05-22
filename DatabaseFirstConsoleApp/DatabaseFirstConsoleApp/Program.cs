using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EntityFrameworkTestEntities1();
            var post = new Post()
            {
                DatePublished = DateTime.Now,
                Title = "First Message",
                Body = "this is a message",
                PostID = 1

            };
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
