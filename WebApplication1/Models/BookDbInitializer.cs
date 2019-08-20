using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class BookDbInitializer: DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 220,image= "https://b1.culture.ru/c/365442.jpg" });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 180,image= "https://cdn.book24.ru/v2/ASE000000000706534/COVER/cover3d1__w674.jpg" });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 150,image= "https://cdn.27.ua/499/d8/79/317561_1.jpeg" });

            base.Seed(db);
        }
    }
}