using System.Data.Entity;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    //DBContexten kalıtım oldu
    public class Context: DbContext
    {
        /// <summary>
        /// Abouts yazan kısmı veritabanındaki tablo adı olacak
        /// </summary>
        public DbSet<About> Abouts { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

        public DbSet<Message> Message { get; set; }

    }
}
