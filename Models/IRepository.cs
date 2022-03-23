using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class IRepository
    {
        IQueryable<Booking> Book { get; }

        public void SaveBook(Booking b);

        public void CreateBook(Booking b);

        public void DeleteBook(Booking b);

    }
}
