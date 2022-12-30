using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact>  Contacts { get; set; }
        public DbSet<Content>  Contents { get; set; }
        public DbSet<Heading>  Headings { get; set; }
        public DbSet<Writer>  Writers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }

    //EnttyLayera tanımladığımız tablolar migration yapmak için öncelikle burda tanımlanmalıdır
    /* References üzerinden EntityLayer referans verilerek About Kullanıldı */
    /* About proje üzerinde kullanılan bilgi / Abouts SQL tablo ismi*/
}
