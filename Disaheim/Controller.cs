using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class Controller
    {
        ValuableRepository valuableRepo = new ValuableRepository();
      

        public void AddToList(IValuable valuables)
        {
            valuableRepo.AddValuable(valuables);

        }

        /*
        public List<Book> Books = new List<Book>();

        public void AddToList(Book book)
        {
            Books.Add(book);
        }

        public List<Amulet> Amulets = new List<Amulet>();

        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }*/
    }
}
