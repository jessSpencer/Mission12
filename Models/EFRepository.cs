using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class EFRepository : IRepository
    {
        private AptContext context { get; set; }

        public EFRepository (AptContext temp)
        {
            context = temp;
        }

        public IQueryable<Booking> Book => context.Booking;

        public void SaveBook(Booking b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Booking b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Booking b)
        {
            context.Remove(b);
            context.SaveChanges();
        }

    }
}
